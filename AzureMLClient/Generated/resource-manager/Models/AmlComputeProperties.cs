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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AML Compute properties
    /// </summary>
    public partial class AmlComputeProperties
    {
        /// <summary>
        /// Initializes a new instance of the AmlComputeProperties class.
        /// </summary>
        public AmlComputeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmlComputeProperties class.
        /// </summary>
        /// <param name="vmSize">Virtual Machine Size</param>
        /// <param name="vmPriority">Virtual Machine priority. Possible values
        /// include: 'Dedicated', 'LowPriority'</param>
        /// <param name="scaleSettings">Scale settings for AML Compute</param>
        /// <param name="userAccountCredentials">User account
        /// credentials.</param>
        /// <param name="subnet">Subnet.</param>
        /// <param name="remoteLoginPortPublicAccess">Close remote Login Access
        /// Port</param>
        /// <param name="allocationState">Allocation state.</param>
        /// <param name="allocationStateTransitionTime">Allocation state
        /// transition time.</param>
        /// <param name="errors">Errors.</param>
        /// <param name="currentNodeCount">Current node count.</param>
        /// <param name="targetNodeCount">Target node count.</param>
        /// <param name="nodeStateCounts">Node state counts.</param>
        public AmlComputeProperties(string vmSize = default(string), string vmPriority = default(string), ScaleSettings scaleSettings = default(ScaleSettings), UserAccountCredentials userAccountCredentials = default(UserAccountCredentials), ResourceId subnet = default(ResourceId), string remoteLoginPortPublicAccess = default(string), string allocationState = default(string), System.DateTime? allocationStateTransitionTime = default(System.DateTime?), IList<MachineLearningServiceError> errors = default(IList<MachineLearningServiceError>), int? currentNodeCount = default(int?), int? targetNodeCount = default(int?), NodeStateCounts nodeStateCounts = default(NodeStateCounts))
        {
            VmSize = vmSize;
            VmPriority = vmPriority;
            ScaleSettings = scaleSettings;
            UserAccountCredentials = userAccountCredentials;
            Subnet = subnet;
            RemoteLoginPortPublicAccess = remoteLoginPortPublicAccess;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            Errors = errors;
            CurrentNodeCount = currentNodeCount;
            TargetNodeCount = targetNodeCount;
            NodeStateCounts = nodeStateCounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets virtual Machine Size
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets virtual Machine priority. Possible values include:
        /// 'Dedicated', 'LowPriority'
        /// </summary>
        [JsonProperty(PropertyName = "vmPriority")]
        public string VmPriority { get; set; }

        /// <summary>
        /// Gets or sets scale settings for AML Compute
        /// </summary>
        [JsonProperty(PropertyName = "scaleSettings")]
        public ScaleSettings ScaleSettings { get; set; }

        /// <summary>
        /// Gets or sets user account credentials.
        /// </summary>
        /// <remarks>
        /// Credentials for an administrator user account that will be created
        /// on each compute node.
        /// </remarks>
        [JsonProperty(PropertyName = "userAccountCredentials")]
        public UserAccountCredentials UserAccountCredentials { get; set; }

        /// <summary>
        /// Gets or sets subnet.
        /// </summary>
        /// <remarks>
        /// Virtual network subnet resource ID the compute nodes belong to.
        /// </remarks>
        [JsonProperty(PropertyName = "subnet")]
        public ResourceId Subnet { get; set; }

        /// <summary>
        /// Gets or sets close remote Login Access Port
        /// </summary>
        /// <remarks>
        /// State of the public SSH port. Possible values are: Disabled -
        /// Indicates that the public ssh port is closed on all nodes of the
        /// cluster. Enabled - Indicates that the public ssh port is open on
        /// all nodes of the cluster. NotSpecified - Indicates that the public
        /// ssh port is closed on all nodes of the cluster if VNet is defined,
        /// else is open all public nodes. It can be default only during
        /// cluster creation time, after creation it will be either enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled',
        /// 'NotSpecified'
        /// </remarks>
        [JsonProperty(PropertyName = "remoteLoginPortPublicAccess")]
        public string RemoteLoginPortPublicAccess { get; set; }

        /// <summary>
        /// Gets allocation state.
        /// </summary>
        /// <remarks>
        /// Allocation state of the compute. Possible values are: steady -
        /// Indicates that the compute is not resizing. There are no changes to
        /// the number of compute nodes in the compute in progress. A compute
        /// enters this state when it is created and when no operations are
        /// being performed on the compute to change the number of compute
        /// nodes. resizing - Indicates that the compute is resizing; that is,
        /// compute nodes are being added to or removed from the compute.
        /// Possible values include: 'Steady', 'Resizing'
        /// </remarks>
        [JsonProperty(PropertyName = "allocationState")]
        public string AllocationState { get; private set; }

        /// <summary>
        /// Gets allocation state transition time.
        /// </summary>
        /// <remarks>
        /// The time at which the compute entered its current allocation state.
        /// </remarks>
        [JsonProperty(PropertyName = "allocationStateTransitionTime")]
        public System.DateTime? AllocationStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets errors.
        /// </summary>
        /// <remarks>
        /// Collection of errors encountered by various compute nodes during
        /// node setup.
        /// </remarks>
        [JsonProperty(PropertyName = "errors")]
        public IList<MachineLearningServiceError> Errors { get; private set; }

        /// <summary>
        /// Gets current node count.
        /// </summary>
        /// <remarks>
        /// The number of compute nodes currently assigned to the compute.
        /// </remarks>
        [JsonProperty(PropertyName = "currentNodeCount")]
        public int? CurrentNodeCount { get; private set; }

        /// <summary>
        /// Gets target node count.
        /// </summary>
        /// <remarks>
        /// The target number of compute nodes for the compute. If the
        /// allocationState is resizing, this property denotes the target node
        /// count for the ongoing resize operation. If the allocationState is
        /// steady, this property denotes the target node count for the
        /// previous resize operation.
        /// </remarks>
        [JsonProperty(PropertyName = "targetNodeCount")]
        public int? TargetNodeCount { get; private set; }

        /// <summary>
        /// Gets node state counts.
        /// </summary>
        /// <remarks>
        /// Counts of various node states on the compute.
        /// </remarks>
        [JsonProperty(PropertyName = "nodeStateCounts")]
        public NodeStateCounts NodeStateCounts { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleSettings != null)
            {
                ScaleSettings.Validate();
            }
            if (UserAccountCredentials != null)
            {
                UserAccountCredentials.Validate();
            }
            if (Subnet != null)
            {
                Subnet.Validate();
            }
        }
    }
}
