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

    public partial class HdiConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the HdiConfiguration class.
        /// </summary>
        public HdiConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HdiConfiguration class.
        /// </summary>
        /// <param name="yarnDeployMode">Possible values include: 'None',
        /// 'Client', 'Cluster'</param>
        public HdiConfiguration(YarnDeployMode? yarnDeployMode = default(YarnDeployMode?))
        {
            YarnDeployMode = yarnDeployMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Client', 'Cluster'
        /// </summary>
        [JsonProperty(PropertyName = "yarnDeployMode")]
        public YarnDeployMode? YarnDeployMode { get; set; }

    }
}
