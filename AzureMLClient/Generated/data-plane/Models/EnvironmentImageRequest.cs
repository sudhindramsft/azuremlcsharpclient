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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to create a Docker image based on Environment.
    /// </summary>
    public partial class EnvironmentImageRequest
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentImageRequest class.
        /// </summary>
        public EnvironmentImageRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentImageRequest class.
        /// </summary>
        /// <param name="driverProgram">The name of the driver file.</param>
        /// <param name="assets">The list of assets.</param>
        /// <param name="modelIds">The list of model Ids.</param>
        /// <param name="environment">The details of the AZURE ML
        /// environment.</param>
        public EnvironmentImageRequest(string driverProgram = default(string), IList<EnvironmentImageAsset> assets = default(IList<EnvironmentImageAsset>), IList<string> modelIds = default(IList<string>), ModelEnvironmentDefinition environment = default(ModelEnvironmentDefinition))
        {
            DriverProgram = driverProgram;
            Assets = assets;
            ModelIds = modelIds;
            Environment = environment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the driver file.
        /// </summary>
        [JsonProperty(PropertyName = "driverProgram")]
        public string DriverProgram { get; set; }

        /// <summary>
        /// Gets or sets the list of assets.
        /// </summary>
        [JsonProperty(PropertyName = "assets")]
        public IList<EnvironmentImageAsset> Assets { get; set; }

        /// <summary>
        /// Gets or sets the list of model Ids.
        /// </summary>
        [JsonProperty(PropertyName = "modelIds")]
        public IList<string> ModelIds { get; set; }

        /// <summary>
        /// Gets or sets the details of the AZURE ML environment.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public ModelEnvironmentDefinition Environment { get; set; }

    }
}