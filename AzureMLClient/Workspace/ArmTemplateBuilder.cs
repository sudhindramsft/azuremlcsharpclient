
namespace AzureMLClient.Workspace
{
    using System;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A helper class used to create Dependant ARM resources and a Workspace
    /// </summary>
    public class ArmTemplateBuilder
    {
        private readonly JObject template = new JObject();

        /// <summary>
        /// Creates an instance of <see cref="ArmTemplateBuilder"/>
        /// </summary>
        public ArmTemplateBuilder()
        {
            var schema = new JProperty("$schema", "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#");
            this.template.Add(schema);
            this.template.Add(new JProperty("contentVersion", "1.0.0.1"));
            this.template.Add(new JProperty("parameters", new JObject()));
            this.template.Add(new JProperty("variables", new JObject()));
            this.template.Add(new JProperty("resources", new JArray()));
        }

        /// <summary>
        /// Returns the ARM template for an AML Workspace
        /// </summary>
        /// <returns></returns>
        public JObject GetTemplate()
        {
            return this.template;
        }

        /// <summary>
        /// Builds the Keyvault ARM template
        /// </summary>
        /// <param name="name">Name of the keyvault</param>
        /// <param name="region">User specified region, where the resource needs to be provisioned</param>
        /// <param name="tenantId">The tenant ID</param>
        /// <returns>The ARM template for a key-vault</returns>
        public static JObject BuildKVTemplate(string name, Region region, string tenantId)
        {
            var res = new JObject
            {
                new JProperty("type", "Microsoft.KeyVault/vaults"),
                new JProperty("name", name),
                new JProperty("apiVersion", "2016-10-01"),
                new JProperty("location", region.ToString()),
                new JProperty("dependsOn", new JArray())
            };

            var properties = new JObject
            {
                new JProperty("enabledForDeployment", true),
                new JProperty("enabledForTemplateDeployment", true),
                new JProperty("enabledForVolumeEncryption", true),
                new JProperty("tenantId", tenantId),
                new JProperty("accessPolicies", new JArray())
            };

            var sku = new JObject
            {
                new JProperty("name", "Standard"),
                new JProperty("family", "A")
            };
            properties.Add(new JProperty("sku", sku));

            res.Add("properties", properties);

            return res;
        }

        /// <summary>
        /// Builds the Storage account ARM template.
        /// </summary>
        /// <param name="name">Name of the keyvault</param>
        /// <param name="region">User specified region, where the resource needs to be provisioned</param>
        /// <returns>The ARM template for a storage account</returns>
        public static JObject BuildStorageAccountTemplate(string name, Region region)
        {
            var res = new JObject
            {
                { "type", "Microsoft.Storage/storageAccounts" },
                { "name", name },
                { "apiVersion", "2018-07-01" },
                { "location", region.ToString() },
                {
                    "sku",
                    new JObject { { "name", "Standard_LRS" } }
                },
                { "kind", "StorageV2" },
                { "dependsOn", new JArray() }
            };

            var properties = new JObject();

            var encryption = new JObject
            {
                {
                    "services",
                    new JObject
                    {
                        { "blob", new JObject { { "enabled", "true" } } },
                        { "file", new JObject { { "enabled", "true" } } }
                    }
                },
                { "keySource", "Microsoft.Storage" }
            };

            properties.Add("encryption", encryption);
            properties.Add(new JProperty("supportsHttpsTrafficOnly", true));

            res.Add("properties", properties);

            return res;
        }

        /// <summary>
        /// Builds an Azure Container ARM template
        /// </summary>
        /// <param name="name">Name of the ACR</param>
        /// <param name="region">User specified region, where the resource needs to be provisioned</param>
        /// <returns>The ARM template for an ACR</returns>
        public static JObject BuildAzureContainerRegistryTemplate(string name, Region region)
        {
            var res = new JObject
            {
                { "type", "Microsoft.ContainerRegistry/registries" },
                { "name", name },
                { "apiVersion", "2017-10-01" },
                { "location", region.ToString() },
                {
                    "sku",
                    new JObject
                    {
                        { "name", "Standard" },
                        { "tier", "Standard" }
                    }
                },
                {
                    "properties",
                    new JObject
                    {
                        { "adminUserEnabled", "true" }
                    }
                }
            };

            return res;
        }

        /// <summary>
        /// Builds an App Insights ARM template
        /// </summary>
        /// <param name="name">Name of the ACR</param>
        /// <param name="region">User specified region, where the resource needs to be provisioned</param>
        /// <returns>The ARM template for an app insights account</returns>
        public JObject BuildApplicationInsightsTemplate(string name, Region region)
        {
            region = this.RemapAppInsightsRegion(region);

            var res = new JObject
            {
                { "type", "Microsoft.Insights/components" },
                { "name", name },
                { "kind", "web" },
                { "apiVersion", "2015-05-01" },
                { "location", region.ToString() },
                {
                    "properties",
                    new JObject
                    {
                        { "Application_Type", "web" }
                    }
                }
            };

            return res;
        }

        /// <summary>
        /// Builds an Azure ML Workspace ARM template
        /// </summary>
        /// <param name="name">Name of the ACR</param>
        /// <param name="region">User specified region, where the resource needs to be provisioned</param>
        /// <param name="keyVaultId">The Keyvault to use</param>
        /// <param name="azureContainerRegistryId">The ACR instance to use</param>
        /// <param name="storageId">The storage account to be used for the default datastore</param>
        /// <param name="applicationInsightsId">The application insights account to use for logging metrics</param>
        /// <returns>The ARM template for an azure ML Workspace</returns>
        public static JObject BuildWorkspaceResource(
            string name,
            Region region,
            string keyVaultId,
            string azureContainerRegistryId,
            string storageId,
            string applicationInsightsId)
        {
            var res = new JObject
            {
                { "type", "Microsoft.MachineLearningServices/workspaces" },
                { "name", name },
                { "apiVersion", "2018-11-19" },
                {
                    "identity",
                    new JObject
                    {
                        { "type", "systemAssigned" }
                    }
                },
                { "location", region.ToString() },
                { "resources", new JArray() },
                { "dependsOn", new JArray() },
                {
                    "properties",
                    new JObject
                    {
                        { "containerRegistry", azureContainerRegistryId },
                        { "keyVault", keyVaultId },
                        { "applicationInsights", applicationInsightsId },
                        { "friendlyName", name },
                        { "storageAccount", storageId }
                    }
                }
            };

            return res;
        }

        /// <summary>
        /// Adds a resource to the ARM template
        /// </summary>
        /// <param name="resource"></param>
        public void AddResource(JObject resource)
        {
            JArray resources = this.template.GetValue("resources") as JArray;
            resources.Add(resource);
        }

        /// <summary>
        /// App insights is not in all locations as us. So, create a map
        /// update according to https://azure.microsoft.com/en-us/global-infrastructure/services/?products=monitor
        /// </summary>
        /// <param name="region">The original region specified by the user</param>
        /// <returns>the remapped region where app insights is supported</returns>
        private Region RemapAppInsightsRegion(Region region)
        {
            if (region == Region.USWestCentral || region == Region.USWest)
            {
                return Region.USWest2;
            }
            if (region == Region.USEast2)
            {
                return Region.USEast;
            }

            return region;
        }
    }
}
