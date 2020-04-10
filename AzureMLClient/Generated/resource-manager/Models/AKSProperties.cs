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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AKS properties
    /// </summary>
    public partial class AKSProperties
    {
        /// <summary>
        /// Initializes a new instance of the AKSProperties class.
        /// </summary>
        public AKSProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AKSProperties class.
        /// </summary>
        /// <param name="clusterFqdn">Cluster full qualified domain
        /// name</param>
        /// <param name="systemServices">System services</param>
        /// <param name="agentCount">Number of agents</param>
        /// <param name="agentVMSize">Agent virtual machine size</param>
        /// <param name="sslConfiguration">SSL configuration</param>
        /// <param name="aksNetworkingConfiguration">AKS networking
        /// configuration for vnet</param>
        public AKSProperties(string clusterFqdn = default(string), IList<SystemService> systemServices = default(IList<SystemService>), int? agentCount = default(int?), string agentVMSize = default(string), SslConfiguration sslConfiguration = default(SslConfiguration), AksNetworkingConfiguration aksNetworkingConfiguration = default(AksNetworkingConfiguration))
        {
            ClusterFqdn = clusterFqdn;
            SystemServices = systemServices;
            AgentCount = agentCount;
            AgentVMSize = agentVMSize;
            SslConfiguration = sslConfiguration;
            AksNetworkingConfiguration = aksNetworkingConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cluster full qualified domain name
        /// </summary>
        [JsonProperty(PropertyName = "clusterFqdn")]
        public string ClusterFqdn { get; set; }

        /// <summary>
        /// Gets system services
        /// </summary>
        [JsonProperty(PropertyName = "systemServices")]
        public IList<SystemService> SystemServices { get; private set; }

        /// <summary>
        /// Gets or sets number of agents
        /// </summary>
        [JsonProperty(PropertyName = "agentCount")]
        public int? AgentCount { get; set; }

        /// <summary>
        /// Gets or sets agent virtual machine size
        /// </summary>
        [JsonProperty(PropertyName = "agentVMSize")]
        public string AgentVMSize { get; set; }

        /// <summary>
        /// Gets or sets SSL configuration
        /// </summary>
        [JsonProperty(PropertyName = "sslConfiguration")]
        public SslConfiguration SslConfiguration { get; set; }

        /// <summary>
        /// Gets or sets AKS networking configuration for vnet
        /// </summary>
        [JsonProperty(PropertyName = "aksNetworkingConfiguration")]
        public AksNetworkingConfiguration AksNetworkingConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AgentCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AgentCount", 1);
            }
            if (AksNetworkingConfiguration != null)
            {
                AksNetworkingConfiguration.Validate();
            }
        }
    }
}
