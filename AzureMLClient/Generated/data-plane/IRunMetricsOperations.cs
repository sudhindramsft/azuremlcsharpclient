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
    /// RunMetricsOperations operations.
    /// </summary>
    public partial interface IRunMetricsOperations
    {
        /// <summary>
        /// Post Metric to a Run.
        /// </summary>
        /// <remarks>
        /// Post a Metric to a specific Run Id.
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
        /// The identifier for a run.
        /// </param>
        /// <param name='metricDto'>
        /// Details of the metric which will be added to the Run Id.
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
        Task<AzureOperationResponse> PostWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, string runId, Metric metricDto = default(Metric), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post Metrics to a Run.
        /// </summary>
        /// <remarks>
        /// Post Metrics to a specific Run Id.
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
        /// The identifier for a run.
        /// </param>
        /// <param name='batchMetricDto'>
        /// Details of the Metrics which will be added to the Run Id.
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
        Task<AzureOperationResponse> BatchPostWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, string runId, BatchMetric batchMetricDto = default(BatchMetric), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Metric details.
        /// </summary>
        /// <remarks>
        /// Get Metric details for a specific Metric Id.
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
        /// <param name='metricId'>
        /// The identifier for a Metric.
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
        Task<AzureOperationResponse<RunMetric>> GetWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, System.Guid metricId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all Run Metrics for the specific Experiment.
        /// </summary>
        /// <remarks>
        /// Get all Run Metrics for the specific Experiment with the specified
        /// query filters.
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
        /// <param name='queryParams'>
        /// Query Parameters for data sorting and filtering.
        /// </param>
        /// <param name='mergeStrategyType'>
        /// The type of merge strategy. Currently supported strategies are:
        /// None - all logged values are returned as individual metrics.
        /// MergeToVector - merges multiple values into a vector of values.
        /// Default - the system determines the behavior. Possible values
        /// include: 'Default', 'None', 'MergeToVector'
        /// </param>
        /// <param name='mergeStrategyOptions'>
        /// Controls behavior of the merge strategy in certain cases; e.g. when
        /// a metric is not merged. Possible values include: 'None',
        /// 'ReportUnmergedMetricsValues'
        /// </param>
        /// <param name='mergeStrategySettingsVersion'>
        /// The strategy settings version.
        /// </param>
        /// <param name='mergeStrategySettingsSelectMetrics'>
        /// Defines how to select metrics when merging them together. Possible
        /// values include: 'SelectAll', 'SelectByFirstValueSchema',
        /// 'SelectByFirstValueSchemaMergeNumericValues'
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
        Task<AzureOperationResponse<IPage<RunMetric>>> GetByQueryWithHttpMessagesAsync(System.Guid subscriptionId, string resourceGroupName, string workspaceName, string experimentName, QueryParams queryParams = default(QueryParams), string mergeStrategyType = default(string), string mergeStrategyOptions = default(string), string mergeStrategySettingsVersion = default(string), string mergeStrategySettingsSelectMetrics = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all Run Metrics for the specific Experiment.
        /// </summary>
        /// <remarks>
        /// Get all Run Metrics for the specific Experiment with the specified
        /// query filters.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RunMetric>>> GetByQueryNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}