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
    /// EventsOperations operations.
    /// </summary>
    public partial interface IEventsOperations
    {
        /// <summary>
        /// Batch post event data.
        /// </summary>
        /// <remarks>
        /// Post event data to a specific Run Id.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='experimentName'>
        /// The experiment name.
        /// </param>
        /// <param name='batchEventCommand'>
        /// The batch of Event details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BatchEventCommandResult>> BatchPostWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, BatchEventCommand batchEventCommand = default(BatchEventCommand), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post event data.
        /// </summary>
        /// <remarks>
        /// Post event data to a specific Run Id.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// The Azure Subscription ID.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Name of the resource group in which the workspace is located.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='experimentName'>
        /// The experiment name.
        /// </param>
        /// <param name='runId'>
        /// The identifier of the Run.
        /// </param>
        /// <param name='eventMessage'>
        /// The Event details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PostWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, string runId, BaseEvent eventMessage = default(BaseEvent), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
