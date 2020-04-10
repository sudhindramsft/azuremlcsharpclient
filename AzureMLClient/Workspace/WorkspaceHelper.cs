// <copyright file="AzureMLCredential.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace AzureMLClient.Workspace
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class WorkspaceHelper : ServiceClient<WorkspaceHelper>, IAzureClient
    {
        /// <summary>
        /// 
        /// </summary>
        public WorkspaceHelper()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public string WorkspaceName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubscriptionId { get; private set; }

        public ServiceClientCredentials Credentials => throw new System.NotImplementedException();

        public int? LongRunningOperationRetryTimeout { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public JsonSerializerSettings SerializationSettings => throw new System.NotImplementedException();

        public JsonSerializerSettings DeserializationSettings => throw new System.NotImplementedException();

        public bool? GenerateClientRequestId { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// The authentication callback delegate which is to be implemented by the client code
        /// </summary>
        /// <param name="authority"> Identifier of the authority, a URL. </param>
        /// <param name="resource"> Identifier of the target resource that is the recipient of the requested token, a URL. </param>
        /// <param name="scope"> The scope of the authentication request. </param>
        /// <returns> access token </returns>
        public delegate Task<string> AuthenticationCallback(string authority, string resource, string scope);

    }
}
