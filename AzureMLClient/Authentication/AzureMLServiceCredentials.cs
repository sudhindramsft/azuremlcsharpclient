
namespace AzureMLClient.Authentication
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using AzureMLClient.Workspace;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;

    public class AzureMLServiceCredentials : ServiceClientCredentials
    {
        public event WorkspaceClient.AuthenticationCallback OnAuthenticate = null;

        /// <summary>
        /// TenantId
        /// </summary>
        public string TenantId { get; private set; }

        /// <summary>
        /// AzureEnvironment
        /// </summary>
        public AzureEnvironment AzureEnvironment { get; private set; }

        public AzureMLServiceCredentials(WorkspaceClient.AuthenticationCallback authenticationCallback,
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
            if (client is WorkspaceClient && client.HttpClient != null)
            {
                HttpClient = client.HttpClient;
            }
        }

        public override async Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            string accessToken = await PreAuthenticate(request.RequestUri).ConfigureAwait(false);
            if (!string.IsNullOrEmpty(accessToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
            else
            {
                HttpResponseMessage response;

                // if this credential is tied to a specific WorkspaceClient reuse its HttpClient to send the
                // initial unauthed request to get the challange, otherwise create a new HttpClient
                HttpClient client = this.HttpClient;

                using (var r = new HttpRequestMessage(request.Method, request.RequestUri))
                {
                    response = await client.SendAsync(r).ConfigureAwait(false);
                }

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    accessToken = await PostAuthenticate(response).ConfigureAwait(false);

                    if (!string.IsNullOrEmpty(accessToken))
                    {
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    }
                }
            }
        }

        protected async Task<string> PreAuthenticate(Uri url)
        {
            if (OnAuthenticate != null)
            {
                var challenge = HttpBearerChallengeCache.GetInstance().GetChallengeForURL(url);

                if (challenge != null)
                {
                    return await OnAuthenticate(
                        challenge.AuthorizationServer,
                        this.AzureEnvironment.ResourceManagerEndpoint,
                        challenge.Scope).ConfigureAwait(false);
                }
            }

            return null;
        }

        protected async Task<string> PostAuthenticate(HttpResponseMessage response)
        {
            // An HTTP 401 Not Authorized error; handle if an authentication callback has been supplied
            if (OnAuthenticate != null)
            {
                // Extract the WWW-Authenticate header and determine if it represents an OAuth2 Bearer challenge
                string authenticateHeader = response.Headers.WwwAuthenticate.ElementAt(0).ToString();

                if (HttpBearerChallenge.IsBearerChallenge(authenticateHeader))
                {
                    var challenge = new HttpBearerChallenge(response.RequestMessage.RequestUri, authenticateHeader);

                    if (challenge != null)
                    {
                        // Update challenge cache
                        HttpBearerChallengeCache.GetInstance().SetChallengeForURL(response.RequestMessage.RequestUri, challenge);

                        // We have an authentication challenge, use it to get a new authorization token
                        return await OnAuthenticate(
                            challenge.AuthorizationServer,
                            this.AzureEnvironment.ResourceManagerEndpoint,
                            challenge.Scope).ConfigureAwait(false);
                    }
                }
            }

            return null;
        }
    }
}
