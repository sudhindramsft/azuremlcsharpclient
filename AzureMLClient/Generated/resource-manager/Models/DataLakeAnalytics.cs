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
    /// A DataLakeAnalytics compute.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataLakeAnalytics")]
    public partial class DataLakeAnalytics : Compute
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalytics class.
        /// </summary>
        public DataLakeAnalytics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataLakeAnalytics class.
        /// </summary>
        /// <param name="computeLocation">Location for the underlying
        /// compute</param>
        /// <param name="provisioningState">The provision state of the cluster.
        /// Valid values are Unknown, Updating, Provisioning, Succeeded, and
        /// Failed. Possible values include: 'Unknown', 'Updating', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="description">The description of the Machine Learning
        /// compute.</param>
        /// <param name="createdOn">The date and time when the compute was
        /// created.</param>
        /// <param name="modifiedOn">The date and time when the compute was
        /// last modified.</param>
        /// <param name="resourceId">ARM resource id of the underlying
        /// compute</param>
        /// <param name="provisioningErrors">Errors during provisioning</param>
        /// <param name="isAttachedCompute">Indicating whether the compute was
        /// provisioned by user and brought from outside if true, or machine
        /// learning service provisioned it if false.</param>
        public DataLakeAnalytics(string computeLocation = default(string), string provisioningState = default(string), string description = default(string), System.DateTime? createdOn = default(System.DateTime?), System.DateTime? modifiedOn = default(System.DateTime?), string resourceId = default(string), IList<MachineLearningServiceError> provisioningErrors = default(IList<MachineLearningServiceError>), bool? isAttachedCompute = default(bool?), DataLakeAnalyticsProperties properties = default(DataLakeAnalyticsProperties))
            : base(computeLocation, provisioningState, description, createdOn, modifiedOn, resourceId, provisioningErrors, isAttachedCompute)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DataLakeAnalyticsProperties Properties { get; set; }

    }
}
