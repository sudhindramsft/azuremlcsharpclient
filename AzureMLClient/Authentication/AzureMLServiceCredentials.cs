// <copyright file="AzureMLCredential.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace AzureMLClient.Authentication
{
    using System;
    using System.Net.Http;
    using AzureMLClient.Workspace;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;

    public class AzureMLServiceCredentials : ServiceClientCredentials
    {
        public event WorkspaceHelper.AuthenticationCallback OnAuthenticate = null;

        /// <summary>
        /// TenantId
        /// </summary>
        public string TenantId { get; private set; }

        /// <summary>
        /// AzureEnvironment
        /// </summary>
        public AzureEnvironment AzureEnvironment { get; private set; }

        public AzureMLServiceCredentials(WorkspaceHelper.AuthenticationCallback authenticationCallback,
            string tenantId,
            AzureEnvironment azureEnvironment)
        {
            OnAuthenticate = authenticationCallback;
            TenantId = tenantId;
            AzureEnvironment = azureEnvironment;
        }

        private HttpClient HttpClient { get; set; } = new HttpClient();

        public override void InitializeServiceClient<T>(ServiceClient<T> client)
        {
            if (client == null)
            {
                throw new ArgumentException($"{nameof(client)} is null");
            }

            base.InitializeServiceClient(client);
            if (client is WorkspaceHelper && client.HttpClient != null)
            {
                HttpClient = client.HttpClient;
            }
        }
    }
}
