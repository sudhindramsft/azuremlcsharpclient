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
    /// Policy configuration properties.
    /// </summary>
    public partial class HyperDriveMedianStoppingPolicyProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperDriveMedianStoppingPolicyProperties class.
        /// </summary>
        public HyperDriveMedianStoppingPolicyProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperDriveMedianStoppingPolicyProperties class.
        /// </summary>
        /// <param name="evaluationInterval">Evaluation interval of the
        /// policy.</param>
        /// <param name="delayEvaluation">Value indicating the number of
        /// sequences for which the first evaluation is delayed.</param>
        public HyperDriveMedianStoppingPolicyProperties(int? evaluationInterval = default(int?), int? delayEvaluation = default(int?))
        {
            EvaluationInterval = evaluationInterval;
            DelayEvaluation = delayEvaluation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets evaluation interval of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "evaluation_interval")]
        public int? EvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets value indicating the number of sequences for which the
        /// first evaluation is delayed.
        /// </summary>
        [JsonProperty(PropertyName = "delay_evaluation")]
        public int? DelayEvaluation { get; set; }

    }
}