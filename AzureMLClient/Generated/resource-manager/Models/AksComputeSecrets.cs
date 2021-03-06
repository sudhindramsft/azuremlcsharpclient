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
    /// Secrets related to a Machine Learning compute based on AKS.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AKS")]
    public partial class AksComputeSecrets : ComputeSecrets
    {
        /// <summary>
        /// Initializes a new instance of the AksComputeSecrets class.
        /// </summary>
        public AksComputeSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AksComputeSecrets class.
        /// </summary>
        /// <param name="userKubeConfig">Content of kubeconfig file that can be
        /// used to connect to the Kubernetes cluster.</param>
        /// <param name="adminKubeConfig">Content of kubeconfig file that can
        /// be used to connect to the Kubernetes cluster.</param>
        /// <param name="imagePullSecretName">Image registry pull
        /// secret.</param>
        public AksComputeSecrets(string userKubeConfig = default(string), string adminKubeConfig = default(string), string imagePullSecretName = default(string))
        {
            UserKubeConfig = userKubeConfig;
            AdminKubeConfig = adminKubeConfig;
            ImagePullSecretName = imagePullSecretName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content of kubeconfig file that can be used to connect
        /// to the Kubernetes cluster.
        /// </summary>
        [JsonProperty(PropertyName = "userKubeConfig")]
        public string UserKubeConfig { get; set; }

        /// <summary>
        /// Gets or sets content of kubeconfig file that can be used to connect
        /// to the Kubernetes cluster.
        /// </summary>
        [JsonProperty(PropertyName = "adminKubeConfig")]
        public string AdminKubeConfig { get; set; }

        /// <summary>
        /// Gets or sets image registry pull secret.
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecretName")]
        public string ImagePullSecretName { get; set; }

    }
}
