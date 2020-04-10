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

    public partial class EnvironmentDefinition
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentDefinition class.
        /// </summary>
        public EnvironmentDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentDefinition class.
        /// </summary>
        /// <param name="name">The name of the environment.</param>
        /// <param name="version">The environment version.</param>
        /// <param name="python">Settings for a Python environment.</param>
        /// <param name="environmentVariables">Definition of environment
        /// variables to be defined in the environment.</param>
        /// <param name="docker">The definition of a Docker container.</param>
        /// <param name="spark">The configuration for a Spark
        /// environment.</param>
        /// <param name="inferencingStackVersion">The inferencing stack version
        /// added to the image. To avoid adding an inferencing stack, do not
        /// set this value. Valid values: "latest".</param>
        public EnvironmentDefinition(string name = default(string), string version = default(string), PythonSection python = default(PythonSection), IDictionary<string, string> environmentVariables = default(IDictionary<string, string>), DockerSection docker = default(DockerSection), SparkSection spark = default(SparkSection), string inferencingStackVersion = default(string))
        {
            Name = name;
            Version = version;
            Python = python;
            EnvironmentVariables = environmentVariables;
            Docker = docker;
            Spark = spark;
            InferencingStackVersion = inferencingStackVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the environment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the environment version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets settings for a Python environment.
        /// </summary>
        [JsonProperty(PropertyName = "python")]
        public PythonSection Python { get; set; }

        /// <summary>
        /// Gets or sets definition of environment variables to be defined in
        /// the environment.
        /// </summary>
        [JsonProperty(PropertyName = "environmentVariables")]
        public IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets the definition of a Docker container.
        /// </summary>
        [JsonProperty(PropertyName = "docker")]
        public DockerSection Docker { get; set; }

        /// <summary>
        /// Gets or sets the configuration for a Spark environment.
        /// </summary>
        [JsonProperty(PropertyName = "spark")]
        public SparkSection Spark { get; set; }

        /// <summary>
        /// Gets or sets the inferencing stack version added to the image. To
        /// avoid adding an inferencing stack, do not set this value. Valid
        /// values: "latest".
        /// </summary>
        [JsonProperty(PropertyName = "inferencingStackVersion")]
        public string InferencingStackVersion { get; set; }

    }
}