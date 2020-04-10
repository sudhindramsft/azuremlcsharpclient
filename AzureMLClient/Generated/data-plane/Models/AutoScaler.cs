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
    /// The Auto Scaler properties.
    /// </summary>
    public partial class AutoScaler
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaler class.
        /// </summary>
        public AutoScaler()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaler class.
        /// </summary>
        /// <param name="autoscaleEnabled">Option to enable/disable auto
        /// scaling.</param>
        /// <param name="minReplicas">The minimum number of replicas to scale
        /// down to.</param>
        /// <param name="maxReplicas">The maximum number of replicas in the
        /// cluster.</param>
        /// <param name="targetUtilization">The target utilization percentage
        /// to use for determining whether to scale the cluster.</param>
        /// <param name="refreshPeriodInSeconds">The amount of seconds to wait
        /// between auto scale updates.</param>
        public AutoScaler(bool? autoscaleEnabled = default(bool?), int? minReplicas = default(int?), int? maxReplicas = default(int?), int? targetUtilization = default(int?), int? refreshPeriodInSeconds = default(int?))
        {
            AutoscaleEnabled = autoscaleEnabled;
            MinReplicas = minReplicas;
            MaxReplicas = maxReplicas;
            TargetUtilization = targetUtilization;
            RefreshPeriodInSeconds = refreshPeriodInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets option to enable/disable auto scaling.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaleEnabled")]
        public bool? AutoscaleEnabled { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of replicas to scale down to.
        /// </summary>
        [JsonProperty(PropertyName = "minReplicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of replicas in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "maxReplicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Gets or sets the target utilization percentage to use for
        /// determining whether to scale the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "targetUtilization")]
        public int? TargetUtilization { get; set; }

        /// <summary>
        /// Gets or sets the amount of seconds to wait between auto scale
        /// updates.
        /// </summary>
        [JsonProperty(PropertyName = "refreshPeriodInSeconds")]
        public int? RefreshPeriodInSeconds { get; set; }

    }
}
