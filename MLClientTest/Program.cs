using System;

namespace MLClientTest
{
    using AzureMLClient.Authentication;
    using AzureMLClient.Workspace;
    using Microsoft.Azure.Management.MachineLearningServices.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var clientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID", EnvironmentVariableTarget.Machine);
            var clientSecret = Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET", EnvironmentVariableTarget.Machine);
            var azureTenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID", EnvironmentVariableTarget.Machine);
            var azureSubscriptionId = Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID", EnvironmentVariableTarget.Machine);

            CreateWorkspaceAndTriggerAPipelineRun(clientId, clientSecret, azureTenantId, azureSubscriptionId).Wait();
        }

        static async System.Threading.Tasks.Task CreateWorkspaceAndTriggerAPipelineRun(string clientId, string clientSecret, string azureTenantId, string azureSubscriptionId)
        {
            // Invoke the ML Client from here to test.
            var credentials = GetAzureMLCredentialFromServicePrincipalWithAutoTokenRefresh(azureTenantId, clientId, clientSecret, azureSubscriptionId);

            var azuremlClient = new WorkspaceClient(credentials, azureTenantId, azureSubscriptionId);

            var region = Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region.Create("southcentralus");
            var workspaceName = "sukovalaTestSDK";
            var rgName = "sukovalaTestSDKRG";
            var workspace = await azuremlClient.CreateOrGetWorkspaceAsync(region, workspaceName, rgName, workspaceName, createResourceGroup: true).ConfigureAwait(false);
            var attachedCompute = await azuremlClient.AttachCompute(region.Name, rgName, workspaceName, computeName: "GPU-Compute", useGPUCompute: true);

            Console.WriteLine(PrettyPrintWorkspace(workspace));
            Console.ReadLine();
        }

        static string PrettyPrintWorkspace(Workspace workspace)
        {
            var strRepresentation = new JObject
            {
                { "Id", workspace.Id},
                { "type", "Microsoft.MachineLearningServices/workspaces" },
                { "name", workspace.Name },
                { "apiVersion", "2020-03-01" },
                { "location", workspace.Location },
                {
                    "properties",
                    new JObject
                    {
                        {"sku", workspace.Sku.Name },
                        { "StorageAccount", workspace.StorageAccount},
                        { "KeyVault", workspace.KeyVault},
                        { "AppInsights", workspace.ApplicationInsights },
                        { "AzureContainerRegistry", workspace.ContainerRegistry },
                    }
                }
            };

            return strRepresentation.ToString(Formatting.Indented);
        }

        static AzureMLServiceCredentials GetAzureMLCredentialFromServicePrincipalWithAutoTokenRefresh(
           string tenantId,
           string clientId,
           string clientSecret,
           string subscriptionId)
        {
            AzureCredentials credentials = SdkContext.AzureCredentialsFactory.FromServicePrincipal(
                clientId,
                clientSecret,
                tenantId,
                AzureEnvironment.AzureGlobalCloud)
                .WithDefaultSubscription(subscriptionId);

            var amc = new AzureMLServiceCredentials(
                async (authority, resource, scope) =>
                {
                    ClientCredential adCredential = new ClientCredential(clientId, clientSecret);
                    AuthenticationContext authenticationContext = new AuthenticationContext(AzureEnvironment.AzureGlobalCloud.AuthenticationEndpoint + tenantId, false);
                    return (await authenticationContext.AcquireTokenAsync(AzureEnvironment.AzureGlobalCloud.ResourceManagerEndpoint, adCredential).ConfigureAwait(false)).AccessToken;
                },
                tenantId,
                AzureEnvironment.AzureGlobalCloud);

            return amc;
        }
    }
}
