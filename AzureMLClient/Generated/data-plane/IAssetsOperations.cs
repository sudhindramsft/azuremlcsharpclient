// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.MachineLearning.Services
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AssetsOperations operations.
    /// </summary>
    public partial interface IAssetsOperations
    {
        /// <summary>
        /// Query the list of Assets in a workspace.
        /// </summary>
        /// <remarks>
        /// If no filter is passed, the query lists all the Assets in the given
        /// workspace. The returned list is paginated and the count of items in
        /// each page is an optional parameter.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroup'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspace'>
        /// The name of the workspace.
        /// </param>
        /// <param name='runId'>
        /// The run Id associated with the Assets.
        /// </param>
        /// <param name='name'>
        /// The object name.
        /// </param>
        /// <param name='count'>
        /// The number of items to retrieve in a page.
        /// </param>
        /// <param name='skipToken'>
        /// The continuation token to retrieve the next page.
        /// </param>
        /// <param name='tags'>
        /// A set of tags with which to filter the returned models.
        /// It is a comma separated string of tags key or tags key=value
        /// Example: tagKey1,tagKey2,tagKey3=value3
        /// </param>
        /// <param name='properties'>
        /// A set of properties with which to filter the returned models.
        /// It is a comma separated string of properties key and/or properties
        /// key=value
        /// Example: propKey1,propKey2,propKey3=value3
        /// </param>
        /// <param name='orderby'>
        /// An option for specifying how to order the list. Possible values
        /// include: 'CreatedAtDesc', 'CreatedAtAsc', 'UpdatedAtDesc',
        /// 'UpdatedAtAsc'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Asset>>> ListQueryWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroup, string workspace, string runId = default(string), string name = default(string), int? count = default(int?), string skipToken = default(string), string tags = default(string), string properties = default(string), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create an Asset.
        /// </summary>
        /// <remarks>
        /// Create an Asset from the provided payload.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroup'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspace'>
        /// The name of the workspace.
        /// </param>
        /// <param name='asset'>
        /// The Asset to be created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Asset>> CreateWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroup, string workspace, Asset asset = default(Asset), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an Asset.
        /// </summary>
        /// <remarks>
        /// Get an Asset by Id.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroup'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspace'>
        /// The name of the workspace.
        /// </param>
        /// <param name='id'>
        /// The Asset Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Asset>> QueryByIdWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroup, string workspace, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an Asset.
        /// </summary>
        /// <remarks>
        /// Delete the specified Asset.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroup'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspace'>
        /// The name of the workspace.
        /// </param>
        /// <param name='id'>
        /// The Id of the Asset to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroup, string workspace, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an Asset.
        /// </summary>
        /// <remarks>
        /// Patch a specific Asset.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroup'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspace'>
        /// The name of the workspace.
        /// </param>
        /// <param name='id'>
        /// The Id of the Asset to patch.
        /// </param>
        /// <param name='patch'>
        /// The payload that is used to patch an Asset.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Asset>> PatchWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroup, string workspace, string id, IList<JsonPatchOperation> patch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Query the list of Assets in a workspace.
        /// </summary>
        /// <remarks>
        /// If no filter is passed, the query lists all the Assets in the given
        /// workspace. The returned list is paginated and the count of items in
        /// each page is an optional parameter.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ModelErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Asset>>> ListQueryNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
