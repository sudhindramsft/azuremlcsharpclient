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

    public partial class ArtifactDetails
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactDetails class.
        /// </summary>
        public ArtifactDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactDetails class.
        /// </summary>
        public ArtifactDetails(string id = default(string), string prefix = default(string))
        {
            Id = id;
            Prefix = prefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

    }
}
