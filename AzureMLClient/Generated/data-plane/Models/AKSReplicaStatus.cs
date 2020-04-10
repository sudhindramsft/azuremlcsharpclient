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

    public partial class AKSReplicaStatus
    {
        /// <summary>
        /// Initializes a new instance of the AKSReplicaStatus class.
        /// </summary>
        public AKSReplicaStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AKSReplicaStatus class.
        /// </summary>
        /// <param name="desiredReplicas">The desired number of
        /// replicas.</param>
        /// <param name="updatedReplicas">The number of updated
        /// replicas.</param>
        /// <param name="availableReplicas">The number of available
        /// replicas.</param>
        /// <param name="error">The error details.</param>
        public AKSReplicaStatus(int? desiredReplicas = default(int?), int? updatedReplicas = default(int?), int? availableReplicas = default(int?), ModelErrorResponse error = default(ModelErrorResponse))
        {
            DesiredReplicas = desiredReplicas;
            UpdatedReplicas = updatedReplicas;
            AvailableReplicas = availableReplicas;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the desired number of replicas.
        /// </summary>
        [JsonProperty(PropertyName = "desiredReplicas")]
        public int? DesiredReplicas { get; set; }

        /// <summary>
        /// Gets or sets the number of updated replicas.
        /// </summary>
        [JsonProperty(PropertyName = "updatedReplicas")]
        public int? UpdatedReplicas { get; set; }

        /// <summary>
        /// Gets or sets the number of available replicas.
        /// </summary>
        [JsonProperty(PropertyName = "availableReplicas")]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ModelErrorResponse Error { get; set; }

    }
}