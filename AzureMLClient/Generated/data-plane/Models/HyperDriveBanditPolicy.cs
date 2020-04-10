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
    /// Bandit Policy configuration. Please refer
    /// https://docs.microsoft.com/en-us/python/api/azureml-train-core/azureml.train.hyperdrive.banditpolicy?view=azure-ml-py
    /// for more information.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Bandit")]
    public partial class HyperDriveBanditPolicy : HyperDrivePolicyConfigBase
    {
        /// <summary>
        /// Initializes a new instance of the HyperDriveBanditPolicy class.
        /// </summary>
        public HyperDriveBanditPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HyperDriveBanditPolicy class.
        /// </summary>
        /// <param name="properties">Policy configuration properties.</param>
        public HyperDriveBanditPolicy(HyperDriveBanditPolicyProperties properties = default(HyperDriveBanditPolicyProperties))
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
        public HyperDriveBanditPolicyProperties Properties { get; set; }

    }
}
