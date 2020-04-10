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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HyperparameterTuningOperations.
    /// </summary>
    public static partial class HyperparameterTuningOperationsExtensions
    {
            /// <summary>
            /// Create an Experiment.
            /// </summary>
            /// <remarks>
            /// Create a HyperDrive Experiment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='armScope'>
            /// The ARM scope passed in through URL with format:
            /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/experiments/{experimentName}.
            /// </param>
            /// <param name='config'>
            /// The configuration file with experiment JSON content. A text file that is a
            /// JSON-serialized '#/definitions/HyperDriveCreateExperiment' object.
            /// </param>
            public static HyperDriveExperimentResponse CreateExperiment(this IHyperparameterTuningOperations operations, string armScope, Stream config)
            {
                return operations.CreateExperimentAsync(armScope, config).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create an Experiment.
            /// </summary>
            /// <remarks>
            /// Create a HyperDrive Experiment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='armScope'>
            /// The ARM scope passed in through URL with format:
            /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/experiments/{experimentName}.
            /// </param>
            /// <param name='config'>
            /// The configuration file with experiment JSON content. A text file that is a
            /// JSON-serialized '#/definitions/HyperDriveCreateExperiment' object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HyperDriveExperimentResponse> CreateExperimentAsync(this IHyperparameterTuningOperations operations, string armScope, Stream config, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateExperimentWithHttpMessagesAsync(armScope, config, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel an Experiment.
            /// </summary>
            /// <remarks>
            /// Cancel a HyperDrive Experiment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='armScope'>
            /// The ARM scope passed in through URL with format:
            /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/experiments/{experimentName}.
            /// </param>
            /// <param name='runId'>
            /// Hyperdrive run id to cancel.
            /// </param>
            /// <param name='runHistoryHost'>
            /// The host for run location.
            /// </param>
            public static HyperDriveCancelExperimentResponse CancelExperiment(this IHyperparameterTuningOperations operations, string armScope, string runId, string runHistoryHost = default(string))
            {
                return operations.CancelExperimentAsync(armScope, runId, runHistoryHost).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel an Experiment.
            /// </summary>
            /// <remarks>
            /// Cancel a HyperDrive Experiment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='armScope'>
            /// The ARM scope passed in through URL with format:
            /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/experiments/{experimentName}.
            /// </param>
            /// <param name='runId'>
            /// Hyperdrive run id to cancel.
            /// </param>
            /// <param name='runHistoryHost'>
            /// The host for run location.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HyperDriveCancelExperimentResponse> CancelExperimentAsync(this IHyperparameterTuningOperations operations, string armScope, string runId, string runHistoryHost = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelExperimentWithHttpMessagesAsync(armScope, runId, runHistoryHost, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}