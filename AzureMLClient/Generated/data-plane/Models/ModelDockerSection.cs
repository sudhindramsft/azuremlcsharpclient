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

    public partial class ModelDockerSection
    {
        /// <summary>
        /// Initializes a new instance of the ModelDockerSection class.
        /// </summary>
        public ModelDockerSection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelDockerSection class.
        /// </summary>
        /// <param name="baseImage">Base image used for Docker-based runs.
        /// Mutually exclusive with BaseDockerfile.</param>
        /// <param name="baseDockerfile">Base Dockerfile used for Docker-based
        /// runs. Mutually exclusive with BaseImage.</param>
        /// <param name="enabled">Set True to perform this run inside a Docker
        /// container.</param>
        /// <param name="sharedVolumes">Set False if necessary to work around
        /// shared volume bugs on Windows.</param>
        /// <param name="gpuSupport">Run with NVidia Docker extension to
        /// support GPUs.</param>
        /// <param name="shmSize">The shared memory size setting for NVidia
        /// GPUs.</param>
        /// <param name="arguments">Extra arguments to the Docker run
        /// command.</param>
        /// <param name="baseImageRegistry">Image registry that contains the
        /// base image.</param>
        public ModelDockerSection(string baseImage = default(string), string baseDockerfile = default(string), bool? enabled = default(bool?), bool? sharedVolumes = default(bool?), bool? gpuSupport = default(bool?), string shmSize = default(string), IList<string> arguments = default(IList<string>), ContainerRegistry baseImageRegistry = default(ContainerRegistry))
        {
            BaseImage = baseImage;
            BaseDockerfile = baseDockerfile;
            Enabled = enabled;
            SharedVolumes = sharedVolumes;
            GpuSupport = gpuSupport;
            ShmSize = shmSize;
            Arguments = arguments;
            BaseImageRegistry = baseImageRegistry;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base image used for Docker-based runs. Mutually
        /// exclusive with BaseDockerfile.
        /// </summary>
        [JsonProperty(PropertyName = "baseImage")]
        public string BaseImage { get; set; }

        /// <summary>
        /// Gets or sets base Dockerfile used for Docker-based runs. Mutually
        /// exclusive with BaseImage.
        /// </summary>
        [JsonProperty(PropertyName = "baseDockerfile")]
        public string BaseDockerfile { get; set; }

        /// <summary>
        /// Gets or sets set True to perform this run inside a Docker
        /// container.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets set False if necessary to work around shared volume
        /// bugs on Windows.
        /// </summary>
        [JsonProperty(PropertyName = "sharedVolumes")]
        public bool? SharedVolumes { get; set; }

        /// <summary>
        /// Gets or sets run with NVidia Docker extension to support GPUs.
        /// </summary>
        [JsonProperty(PropertyName = "gpuSupport")]
        public bool? GpuSupport { get; set; }

        /// <summary>
        /// Gets or sets the shared memory size setting for NVidia GPUs.
        /// </summary>
        [JsonProperty(PropertyName = "shmSize")]
        public string ShmSize { get; set; }

        /// <summary>
        /// Gets or sets extra arguments to the Docker run command.
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public IList<string> Arguments { get; set; }

        /// <summary>
        /// Gets or sets image registry that contains the base image.
        /// </summary>
        [JsonProperty(PropertyName = "baseImageRegistry")]
        public ContainerRegistry BaseImageRegistry { get; set; }

    }
}
