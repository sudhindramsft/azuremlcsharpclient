// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Counts of various compute node states on the amlCompute.
    /// </summary>
    public partial class NodeStateCounts
    {
        /// <summary>
        /// Initializes a new instance of the NodeStateCounts class.
        /// </summary>
        public NodeStateCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeStateCounts class.
        /// </summary>
        /// <param name="idleNodeCount">Idle node count.</param>
        /// <param name="runningNodeCount">Running node count.</param>
        /// <param name="preparingNodeCount">Preparing node count.</param>
        /// <param name="unusableNodeCount">Unusable node count.</param>
        /// <param name="leavingNodeCount">Leaving node count.</param>
        /// <param name="preemptedNodeCount">Preempted node count.</param>
        public NodeStateCounts(int? idleNodeCount = default(int?), int? runningNodeCount = default(int?), int? preparingNodeCount = default(int?), int? unusableNodeCount = default(int?), int? leavingNodeCount = default(int?), int? preemptedNodeCount = default(int?))
        {
            IdleNodeCount = idleNodeCount;
            RunningNodeCount = runningNodeCount;
            PreparingNodeCount = preparingNodeCount;
            UnusableNodeCount = unusableNodeCount;
            LeavingNodeCount = leavingNodeCount;
            PreemptedNodeCount = preemptedNodeCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets idle node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes in idle state.
        /// </remarks>
        [JsonProperty(PropertyName = "idleNodeCount")]
        public int? IdleNodeCount { get; private set; }

        /// <summary>
        /// Gets running node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes which are running jobs.
        /// </remarks>
        [JsonProperty(PropertyName = "runningNodeCount")]
        public int? RunningNodeCount { get; private set; }

        /// <summary>
        /// Gets preparing node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes which are being prepared.
        /// </remarks>
        [JsonProperty(PropertyName = "preparingNodeCount")]
        public int? PreparingNodeCount { get; private set; }

        /// <summary>
        /// Gets unusable node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes which are in unusable state.
        /// </remarks>
        [JsonProperty(PropertyName = "unusableNodeCount")]
        public int? UnusableNodeCount { get; private set; }

        /// <summary>
        /// Gets leaving node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes which are leaving the amlCompute.
        /// </remarks>
        [JsonProperty(PropertyName = "leavingNodeCount")]
        public int? LeavingNodeCount { get; private set; }

        /// <summary>
        /// Gets preempted node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes which are in preempted state.
        /// </remarks>
        [JsonProperty(PropertyName = "preemptedNodeCount")]
        public int? PreemptedNodeCount { get; private set; }

    }
}