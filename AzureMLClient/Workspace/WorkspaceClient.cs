
namespace AzureMLClient.Workspace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.MachineLearningServices.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class WorkspaceClient : ServiceClient<WorkspaceClient>, IAzureClient
    {
        public const string MicrosoftAzureTenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";

        /// <summary>
        /// Initializes a new instance of the WorkspacesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, string tenantId, AzureEnvironment azureEnvironment, params DelegatingHandler[] handlers)
            : base(handlers)
        {
            TenantId = string.IsNullOrEmpty(tenantId) ? throw new ArgumentException($"{nameof(tenantId)} is not set") : tenantId;
            Credentials = credentials ?? throw new ArgumentException($"{nameof(credentials)} is not set");

            BaseUri = new Uri(azureEnvironment.ResourceManagerEndpoint);
            AzureEnvironment = azureEnvironment;
            Credentials.InitializeServiceClient(this);
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(credentials, MicrosoftAzureTenantId, AzureEnvironment.AzureGlobalCloud, handlers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public WorkspaceClient(ServiceClientCredentials credentials, string tenantId, params DelegatingHandler[] handlers)
            : this(credentials, tenantId, AzureEnvironment.AzureGlobalCloud, handlers)
        {
        }

        /// <summary>
        /// Client API version.
        /// </summary>
        public string ApiVersion { get; private set; } = "2018-11-19";

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; } = "en-US";

        public ServiceClientCredentials Credentials { get; private set; }

        public int? LongRunningOperationRetryTimeout { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public JsonSerializerSettings SerializationSettings { get; private set; }

        public JsonSerializerSettings DeserializationSettings { get; private set; }

        public bool? GenerateClientRequestId { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// The authentication callback delegate which is to be implemented by the client code
        /// </summary>
        /// <param name="authority"> Identifier of the authority, a URL. </param>
        /// <param name="resource"> Identifier of the target resource that is the recipient of the requested token, a URL. </param>
        /// <param name="scope"> The scope of the authentication request. </param>
        /// <returns> access token </returns>
        public delegate Task<string> AuthenticationCallback(string authority, string resource, string scope);

        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; private set; }

        /// <summary>
        /// The tenantId for the Azure Active Directory Service
        /// </summary>
        public string TenantId { get; private set; }

        /// <summary>
        /// The type of Azure cloud (AzurePublicCloud)
        /// </summary>
        public AzureEnvironment AzureEnvironment { get; private set; } = AzureEnvironment.AzureGlobalCloud;

        public async Task<Workspace> CreateWorkspaceAsync(Region region,
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
                storageAccountName = this.GenerateNameForDependentResource(workspaceName, DependentResourceType.StorageAccount);
            }

            if (string.IsNullOrEmpty(keyVaultName))
            {
                keyVaultName = this.GenerateNameForDependentResource(workspaceName, DependentResourceType.KeyVault);
            }

            if (string.IsNullOrEmpty(applicationInsightsName))
            {
                applicationInsightsName = this.GenerateNameForDependentResource(workspaceName, DependentResourceType.ApplicationInsights);
            }

            if (string.IsNullOrEmpty(azureContainerRegistryName))
            {
                azureContainerRegistryName = this.GenerateNameForDependentResource(workspaceName, DependentResourceType.ContainerRegistry);
            }

            if (!this.ValidateApplicationInsightName(applicationInsightsName))
            {
                throw new ArgumentException($"Application Insights name name is invalid, does not conform to Azure naming rules.  {applicationInsightsName}");
            }

            if (!this.ValidateAzureDNSName(keyVaultName))
            {
                throw new ArgumentException($"Key Vault name is invalid, does not conform to Azure naming rules.  {keyVaultName}");
            }

            if (!this.ValidateAzureContainerName(azureContainerRegistryName))
            {
                throw new ArgumentException($"Container Registry name is invalid, does not conform to Azure naming rules.  {azureContainerRegistryName}");
            }

            if (!this.ValidateAzureDNSName(storageAccountName))
            {
                throw new ArgumentException($"Storage Account name is invalid, does not conform to Azure naming rules.  {storageAccountName}");
            }

            var template = new ArmTemplateBuilder();
            var workspace_dependencies = new JArray();

            // Build KeyVault
            JObject kvResource = ArmTemplateBuilder.BuildKVTemplate(keyVaultName, region, this.TenantId);

            template.AddResource(kvResource);
            workspace_dependencies.Add($"[resourceId('{"Microsoft.KeyVault"}/{"vaults"}', '{keyVaultName}')]");

            string kvResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.KeyVault/vaults", keyVaultName);

            // Build Storage Account
            JObject storageResource = ArmTemplateBuilder.BuildStorageAccountTemplate(storageAccountName, region);
            template.AddResource(storageResource);

            workspace_dependencies.Add($"[resourceId('{"Microsoft.Storage"}/{"storageAccounts"}', '{storageAccountName}')]");
            string storageResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.Storage/storageAccounts", storageAccountName);

            // Build Azure Container Registry
            JObject acrResource = ArmTemplateBuilder.BuildAzureContainerRegistryTemplate(azureContainerRegistryName, region);
            template.AddResource(acrResource);
            workspace_dependencies.Add($"[resourceId('{"Microsoft.ContainerRegistry"}/{"registries"}', '{azureContainerRegistryName}')]");
            string acrResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.ContainerRegistry/registries", azureContainerRegistryName);

            // Build App Insights Instance
            JObject appInsightsResource = template.BuildApplicationInsightsTemplate(applicationInsightsName, region);
            template.AddResource(appInsightsResource);
            workspace_dependencies.Add($"[resourceId('{"Microsoft.Insights"}/{"components"}', '{applicationInsightsName}')]");
            string appInsightsResourceId = GetArmResourceId(subscriptionId.ToString(), resourceGroupName, "Microsoft.Insights/components", applicationInsightsName);

            // Build Workspace
            JObject workspaceResource = ArmTemplateBuilder.BuildWorkspaceResource(workspaceName, region, kvResourceId, acrResourceId, storageResourceId, appInsightsResourceId);
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

            return await GetWorkspace(subscriptionId, resourceGroupName, workspaceName).ConfigureAwait(false);
        }

        public async Task<Workspace> GetWorkspace(Guid subscriptionId,
            string resourceGroupName,
            string workspaceName,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            string baseUri = this.HttpClient.BaseAddress.AbsoluteUri;
            var url = new Uri(new Uri(baseUri + (baseUri.EndsWith("/") ? string.Empty : "/")), "subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspace}").ToString();
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(subscriptionId, SerializationSettings).Trim('"')));
            url = url.Replace("{resourceGroupName}", Uri.EscapeDataString(resourceGroupName));
            url = url.Replace("{workspace}", Uri.EscapeDataString(workspaceName));

            // Get the API version string
            var queryParameters = new List<string>
            {
                $"api-version={Uri.EscapeDataString(ApiVersion)}"
            };


            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }

            // Create HTTP transport objects
            using var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri(url)
            };

            if (customHeaders != null)
            {
                foreach (var header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(header.Key))
                    {
                        httpRequest.Headers.Remove(header.Key);
                    }
                    httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            // Set Credentials
            if (this.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }

            // Send Request
            using HttpResponseMessage httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (httpResponse.StatusCode != HttpStatusCode.OK)
            {
                var msg = $"Got {(int)httpResponse.StatusCode} response from service";
                var e = new MachineLearningServiceErrorException(msg)
                {
                    Request = new HttpRequestMessageWrapper(httpRequest, string.Empty),
                    Response = new HttpResponseMessageWrapper(httpResponse, string.Empty)
                };

                throw e;
            }

            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                return SafeJsonConvert.DeserializeObject<Workspace>(responseContent, this.DeserializationSettings);
            }
            catch (JsonException ex)
            {
                throw new SerializationException("Unable to deserialize the response.", responseContent, ex);
            }
        }


        /// <summary>
        /// Initialize all necessary properties
        /// </summary>
        private void Initialize()
        {
            this.HttpClient.BaseAddress = BaseUri;

            this.ApiVersion = "2018-11-19";
            this.AcceptLanguage = "en-US";

            this.SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new Iso8601TimeSpanConverter()
                }
            };

            this.DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new Iso8601TimeSpanConverter()
                }
            };
        }


        private bool ValidateWorkspaceName(string name)
        {
            string pattern = @"^([a-zA-Z0-9][\w\-]){2,32}$";

            return ExecuteMatch(name, pattern);
        }

        private bool ValidateExperimentName(string name)
        {
            string pattern = @"^([a-zA-Z0-9\w\-]){0,35}$";

            return ExecuteMatch(name, pattern);
        }

        // Vault Name must contain only alphanumeric characters and dashes, must start with a letter.
        // Vault Name is limited to 3-24 alphanumeric characters.
        // No consecutive hypens, can't start or end with hyphen
        private bool ValidateAzureDNSName(string name)
        {
            string pattern = @"^([a-zA-Z0-9\w\-]){0,35}$";

            return ExecuteMatch(name, pattern);
        }

        // Application Insights Names use the same rules as ValidateResourceGroupName
        private bool ValidateApplicationInsightName(string name)
        {
            return ValidateResourceGroupName(name);
        }

        // Valid resource group names are located here:
        // https://docs.microsoft.com/en-us/rest/api/resources/resourcegroups/createorupdate
        private bool ValidateResourceGroupName(string name)
        {
            string pattern = @"^([-\w\._\(\)]){0,89}[-\w_\(\)]$";

            return ExecuteMatch(name, pattern);
        }

        // Valid resource group names are located here:
        // https://docs.microsoft.com/en-us/rest/api/resources/resourcegroups/createorupdate
        // names can contain uppercase characters
        private bool ValidateAzureContainerName(string name)
        {
            string pattern = @"^([a-zA-Z0-9]){5,50}[-\w_\(\)]$";

            return ExecuteMatch(name, pattern);
        }

        private bool ExecuteMatch(string name, string pattern)
        {
            if (name == null || pattern == null)
            {
                return false;
            }

            return new Regex(pattern).IsMatch(name);
        }

        private string GenerateRandomString(int length = 8, bool alphanumeric = true)
        {
            if (length < 1)
            {
                throw new ArgumentException(string.Format("length must be greater than 0, {0} specified", length));
            }

            string chars = "abcdefghijklmnopqrstuvwxyz";
            char[] newArray = new char[length];
            Random random = new Random();

            if (alphanumeric)
            {
                chars = string.Concat("0123456789", chars);
            }

            for (int i = 0; i < length; i++)
            {
                newArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(newArray);
        }

        private string GenerateNameForDependentResource(string workspaceName, DependentResourceType resourceType)
        {
            if (string.IsNullOrEmpty(workspaceName))
            {
                throw new ArgumentException($"{nameof(workspaceName)} is not set.");
            }

            string dependentName = string.Concat(workspaceName.Where(ch => char.IsLetterOrDigit(ch)));
            dependentName = string.Concat(dependentName, resourceType.ToString().ToLower().Substring(0, 8));
            dependentName = string.Concat(dependentName, GenerateRandomString());
            if (resourceType == DependentResourceType.StorageAccount
                || resourceType == DependentResourceType.KeyVault)
            {
                dependentName = dependentName.ToLowerInvariant();
            }

            // resources can't start with digits
            if (char.IsDigit(dependentName[0]))
            {
                dependentName = string.Concat(GenerateRandomString(1, false), dependentName);
            }

            return dependentName.Substring(0, 23);
        }

        private string GetArmResourceId(string subscriptionId, string regionName, string provider, string resourceName)
        {
            string format = "/subscriptions/{0}/resourceGroups/{1}/providers/{2}/{3}";

            return string.Format(format, subscriptionId, regionName, provider, resourceName);
        }

        enum DependentResourceType
        {
            KeyVault,
            ApplicationInsights,
            StorageAccount,
            ResourceGroup,
            ContainerRegistry,
            MachineLearningWorkspace
        }
    }
}
