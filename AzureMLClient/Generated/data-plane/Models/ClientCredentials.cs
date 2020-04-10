// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.MachineLearning.Services.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ClientCredentials
    {
        /// <summary>
        /// Initializes a new instance of the ClientCredentials class.
        /// </summary>
        public ClientCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientCredentials class.
        /// </summary>
        /// <param name="clientId">The Client ID/Application ID</param>
        /// <param name="tenantId">The ID of the tenant the service
        /// principal/app belongs to</param>
        /// <param name="isCertAuth">Is it using certificate to authenticate.
        /// If false then use client secret</param>
        /// <param name="certificate">The content of the certificate used for
        /// authentication</param>
        /// <param name="thumbprint">The thumbprint of the certificate
        /// above</param>
        /// <param name="clientSecret">The client secret</param>
        /// <param name="authorityUrl">The authority URL used for
        /// authentication</param>
        /// <param name="resourceUri">The resource the service principal/app
        /// has access to</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <param name="resourceGroup">Resource Group Name</param>
        public ClientCredentials(System.Guid? clientId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), bool? isCertAuth = default(bool?), string certificate = default(string), string thumbprint = default(string), string clientSecret = default(string), string authorityUrl = default(string), string resourceUri = default(string), System.Guid? subscriptionId = default(System.Guid?), string resourceGroup = default(string))
        {
            ClientId = clientId;
            TenantId = tenantId;
            IsCertAuth = isCertAuth;
            Certificate = certificate;
            Thumbprint = thumbprint;
            ClientSecret = clientSecret;
            AuthorityUrl = authorityUrl;
            ResourceUri = resourceUri;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Client ID/Application ID
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public System.Guid? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the tenant the service principal/app belongs
        /// to
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets is it using certificate to authenticate. If false then
        /// use client secret
        /// </summary>
        [JsonProperty(PropertyName = "isCertAuth")]
        public bool? IsCertAuth { get; set; }

        /// <summary>
        /// Gets or sets the content of the certificate used for authentication
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint of the certificate above
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the client secret
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the authority URL used for authentication
        /// </summary>
        [JsonProperty(PropertyName = "authorityUrl")]
        public string AuthorityUrl { get; set; }

        /// <summary>
        /// Gets or sets the resource the service principal/app has access to
        /// </summary>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or sets subscription Id
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets resource Group Name
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

    }
}
