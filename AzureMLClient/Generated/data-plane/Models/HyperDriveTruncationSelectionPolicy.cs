// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.MachineLearning.Services.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Truncation selection policy configuration. Please refer
    /// https://docs.microsoft.com/en-us/python/api/azureml-train-core/azureml.train.hyperdrive.truncationselectionpolicy?view=azure-ml-py
    /// for more information.
    /// </summary>
    [Newtonsoft.Json.JsonObject("TruncationSelection")]
    public partial class HyperDriveTruncationSelectionPolicy : HyperDrivePolicyConfigBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperDriveTruncationSelectionPolicy class.
        /// </summary>
        public HyperDriveTruncationSelectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperDriveTruncationSelectionPolicy class.
        /// </summary>
        /// <param name="properties">Policy configuration properties.</param>
        public HyperDriveTruncationSelectionPolicy(HyperDriveTruncationSelectionPolicyProperties properties = default(HyperDriveTruncationSelectionPolicyProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy configuration properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public HyperDriveTruncationSelectionPolicyProperties Properties { get; set; }

    }
}
