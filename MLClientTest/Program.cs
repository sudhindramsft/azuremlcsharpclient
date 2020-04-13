using System;

namespace MLClientTest
{
    using AzureMLClient.Authentication;
    using AzureMLClient.Workspace;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

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

            var azuremlClient = new WorkspaceClient(credentials, WorkspaceClient.MicrosoftAzureTenantId);

            var region = Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region.Create("southcentralus");
            var workspaceName = "sukovaladotnet";
            var rgName = "sukovaladotnetRG";
            var workspace = await azuremlClient.CreateWorkspaceAsync(region, workspaceName, Guid.Parse(azureSubscriptionId), rgName, workspaceName, createResourceGroup: true).ConfigureAwait(false);
            Console.WriteLine(workspace);
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
