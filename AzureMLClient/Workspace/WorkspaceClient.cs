
namespace AzureMLClient.Workspace
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.MachineLearningServices;
    using Microsoft.Azure.Management.MachineLearningServices.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
    using Microsoft.Rest;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class WorkspaceClient
    {
        public const string MicrosoftAzureTenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";

        /// <summary>
        /// GPU VM Size,
        /// This VM size has Nvidia Tesla GPUs
        /// </summary>
        public const string GPUComputeVmSize = "STANDARD_NC6S_V2";

        /// <summary>
        /// Standard VM Size 
        /// </summary>
        public const string CPUComputeVmSize = "STANDARD_D2_V2";

        /// <summary>
        /// Initializes a new instance of the WorkspacesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='tenantId'>
        /// Required. The AAD tenant ID
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The Azure Subscription ID to use.
        /// </param>
        /// <param name='azureEnvironment'>
        /// Required. The <see cref="AzureEnvironment"/> instance.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, string tenantId, string subscriptionId, AzureEnvironment azureEnvironment, params DelegatingHandler[] handlers)
        {
            this.Credentials = credentials;
            TenantId = string.IsNullOrEmpty(tenantId) ? throw new ArgumentException($"{nameof(tenantId)} is not set") : tenantId;
            this.machineLearningWorkspacesClient = new AzureMachineLearningWorkspacesClient(credentials, handlers);
            this.machineLearningWorkspacesClient.SubscriptionId = subscriptionId;
            this.machineLearningWorkspacesClient.BaseUri = new Uri(azureEnvironment.ResourceManagerEndpoint);
            AzureEnvironment = azureEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The Azure Subscription ID to use.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, string subscriptionId, params DelegatingHandler[] handlers)
            : this(credentials, MicrosoftAzureTenantId, subscriptionId, AzureEnvironment.AzureGlobalCloud, handlers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='tenantId'>
        /// Required. The AAD tenant ID
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The Azure Subscription ID to use.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, string tenantId, string subscriptionId, params DelegatingHandler[] handlers)
            : this(credentials, tenantId, subscriptionId, AzureEnvironment.AzureGlobalCloud, handlers)
        {
        }

        public AzureMachineLearningWorkspacesClient machineLearningWorkspacesClient { get; set; }

        /// <summary>
        /// The authentication callback delegate which is to be implemented by the client code
        /// </summary>
        /// <param name="authority"> Identifier of the authority, a URL. </param>
        /// <param name="resource"> Identifier of the target resource that is the recipient of the requested token, a URL. </param>
        /// <param name="scope"> The scope of the authentication request. </param>
        /// <returns> access token </returns>
        public delegate Task<string> AuthenticationCallback(string authority, string resource, string scope);

        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; private set; }

        /// <summary>
        /// The tenantId for the Azure Active Directory Service
        /// </summary>
        public string TenantId { get; private set; }

        /// <summary>
        /// The type of Azure cloud (AzurePublicCloud)
        /// </summary>
        public AzureEnvironment AzureEnvironment { get; private set; } = AzureEnvironment.AzureGlobalCloud;


        public AmlCompute GetAmlComputeConfiguration(string location, int minNodeCount = 0, int maxNodeCount = 5, string vmSize = CPUComputeVmSize, string vmPriority = "Dedicated")
        {
            return new AmlCompute
            {
                ComputeLocation = location,
                Properties = new AmlComputeProperties
                {
                    ScaleSettings = new ScaleSettings
                    {
                        MinNodeCount = minNodeCount,
                        MaxNodeCount = maxNodeCount,
                        NodeIdleTimeBeforeScaleDown = new TimeSpan(0, 0, 300)
                    },
                    VmPriority = vmPriority,
                    VmSize = vmSize
                }
            };
        }


        public async Task<Workspace> CreateOrGetWorkspaceAsync(Region region,
          string workspaceName,
          string resourceGroupName,
          string friendlyName = null,
          bool createResourceGroup = true,
          string storageAccountName = null,
          string keyVaultName = null,
          string applicationInsightsName = null,
          string azureContainerRegistryName = null,
          CancellationToken cancellationToken = default)
        {
            // check if the workspace exists
            var workspaces = await machineLearningWorkspacesClient.Workspaces.ListBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            var workspace = workspaces.FirstOrDefault(ws => ws.Name == workspaceName);
            if (workspace != null)
                return workspace;

            // Workspace not found, Create one using an ARM template

            var deployment = await this.CreateWorkspaceDeploymentAsync(region,
                workspaceName,
                Guid.Parse(this.machineLearningWorkspacesClient.SubscriptionId),
                resourceGroupName,
                friendlyName,
                createResourceGroup,
                storageAccountName,
                keyVaultName,
                applicationInsightsName,
                azureContainerRegistryName,
                cancellationToken).ConfigureAwait(false);
            return this.machineLearningWorkspacesClient.Workspaces.ListByResourceGroup(resourceGroupName).FirstOrDefault(ws => ws.Name == workspaceName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="resourcegroupName"></param>
        /// <param name="workspaceName"></param>
        /// <param name="computeName"></param>
        /// <param name="useGPUCompute"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ComputeResource> AttachCompute(string location,
            string resourcegroupName,
            string workspaceName,
            string computeName,
            bool useGPUCompute = true,
            CancellationToken cancellationToken = default)
        {
            if(!WorkspaceManagementHelpers.ValidateComputeName(computeName))
            {
                // Provided Compute name is invalid
                throw new ArgumentException(nameof(computeName));
            }
            try
            {
                return await this.machineLearningWorkspacesClient.MachineLearningCompute.GetAsync(resourcegroupName, workspaceName, computeName, cancellationToken).ConfigureAwait(false);
            }
            catch (MachineLearningServiceErrorException mlEx)
            {
                if (mlEx.Body.Error.Code == "ResourceNotFound")
                {
                    AmlCompute computeToAttach = useGPUCompute ? GetAmlComputeConfiguration(location, vmSize: WorkspaceClient.GPUComputeVmSize) : GetAmlComputeConfiguration(location);
                    ComputeResource resource = new ComputeResource
                    {
                        Properties = computeToAttach,
                        Location = location
                    };

                    return await this.machineLearningWorkspacesClient.MachineLearningCompute.CreateOrUpdateAsync(resourcegroupName, workspaceName, computeName, resource, cancellationToken).ConfigureAwait(false);
                }

                throw;
            }
        }

        private async Task<IDeployment> CreateWorkspaceDeploymentAsync(Region region,
          string workspaceName,
          Guid subscriptionId,
          string resourceGroupName,
          string friendlyName = null,
          bool createResourceGroup = true,
          string storageAccountName = null,
          string keyVaultName = null,
          string applicationInsightsName = null,
          string azureContainerRegistryName = null,
          CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(storageAccountName))
            {
                storageAccountName = WorkspaceManagementHelpers.GenerateNameForDependentResource(workspaceName, WorkspaceManagementHelpers.DependentResourceType.StorageAccount);
            }

            if (string.IsNullOrEmpty(keyVaultName))
            {
                keyVaultName = WorkspaceManagementHelpers.GenerateNameForDependentResource(workspaceName, WorkspaceManagementHelpers.DependentResourceType.KeyVault);
            }

            if (string.IsNullOrEmpty(applicationInsightsName))
            {
                applicationInsightsName = WorkspaceManagementHelpers.GenerateNameForDependentResource(workspaceName, WorkspaceManagementHelpers.DependentResourceType.ApplicationInsights);
            }

            if (string.IsNullOrEmpty(azureContainerRegistryName))
            {
                azureContainerRegistryName = WorkspaceManagementHelpers.GenerateNameForDependentResource(workspaceName, WorkspaceManagementHelpers.DependentResourceType.ContainerRegistry);
            }

            if (!WorkspaceManagementHelpers.ValidateApplicationInsightName(applicationInsightsName))
            {
                throw new ArgumentException($"Application Insights name name is invalid, does not conform to Azure naming rules.  {applicationInsightsName}");
            }

            if (!WorkspaceManagementHelpers.ValidateAzureDNSName(keyVaultName))
            {
                throw new ArgumentException($"Key Vault name is invalid, does not conform to Azure naming rules.  {keyVaultName}");
            }

            if (!WorkspaceManagementHelpers.ValidateAzureContainerName(azureContainerRegistryName))
            {
                throw new ArgumentException($"Container Registry name is invalid, does not conform to Azure naming rules.  {azureContainerRegistryName}");
            }

            if (!WorkspaceManagementHelpers.ValidateAzureDNSName(storageAccountName))
            {
                throw new ArgumentException($"Storage Account name is invalid, does not conform to Azure naming rules.  {storageAccountName}");
            }

            var template = new ArmTemplateBuilder();
            var workspace_dependencies = new JArray();

            // Build KeyVault
            JObject kvResource = ArmTemplateBuilder.BuildKVTemplate(keyVaultName, region, this.TenantId);

            template.AddResource(kvResource);
            workspace_dependencies.Add($"[resourceId('Microsoft.KeyVault/vaults', '{keyVaultName}')]");

            string kvResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.KeyVault/vaults", keyVaultName);

            // Build Storage Account
            JObject storageResource = ArmTemplateBuilder.BuildStorageAccountTemplate(storageAccountName, region);
            template.AddResource(storageResource);

            workspace_dependencies.Add($"[resourceId('Microsoft.Storage/storageAccounts', '{storageAccountName}')]");
            string storageResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.Storage/storageAccounts", storageAccountName);

            // Build Azure Container Registry
            JObject acrResource = ArmTemplateBuilder.BuildAzureContainerRegistryTemplate(azureContainerRegistryName, region);
            template.AddResource(acrResource);
            workspace_dependencies.Add($"[resourceId('Microsoft.ContainerRegistry/registries', '{azureContainerRegistryName}')]");
            string acrResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.ContainerRegistry/registries", azureContainerRegistryName);

            // Build App Insights Instance
            JObject appInsightsResource = template.BuildApplicationInsightsTemplate(applicationInsightsName, region);
            template.AddResource(appInsightsResource);
            workspace_dependencies.Add($"[resourceId('Microsoft.Insights/components', '{applicationInsightsName}')]");
            string appInsightsResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.Insights/components", applicationInsightsName);

            // Build Workspace
            JObject workspaceResource = ArmTemplateBuilder.BuildWorkspaceResource(workspaceName, region, kvResourceId, acrResourceId, storageResourceId, friendlyName, appInsightsResourceId);
            workspaceResource.GetValue("dependsOn").Replace(workspace_dependencies);

            template.AddResource(workspaceResource);

            // See https://github.com/Azure-Samples/resources-dotnet-deploy-using-arm-template

            var azure = Azure.Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(new AzureCredentials(this.Credentials, this.Credentials, this.TenantId, AzureEnvironment.AzureGlobalCloud))
                .WithSubscription(subscriptionId.ToString());

            IDeployment deployment;

            if (createResourceGroup)
            {
                deployment = await azure.Deployments.Define(Guid.NewGuid().ToString())
                    .WithNewResourceGroup(resourceGroupName, region)
                    .WithTemplate(template.GetTemplate().ToString())
                    .WithParameters("{}")
                    .WithMode(DeploymentMode.Incremental)
                    .CreateAsync(cancellationToken).ConfigureAwait(false);
            }
            else
            {
                deployment = await azure.Deployments.Define(Guid.NewGuid().ToString())
                    .WithExistingResourceGroup(resourceGroupName)
                    .WithTemplate(template.GetTemplate().ToString())
                    .WithParameters("{}")
                    .WithMode(DeploymentMode.Incremental)
                    .CreateAsync(cancellationToken).ConfigureAwait(false);
            }

            return deployment;
        }

        private static string GetArmResourceId(string subscriptionId, string rgName, string provider, string resourceName)
        {
            return $"/subscriptions/{subscriptionId}/resourceGroups/{rgName}/providers/{provider}/{resourceName}";
        }
    }
}
