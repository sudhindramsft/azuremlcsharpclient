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

    public partial class ModifyExperiment
    {
        /// <summary>
        /// Initializes a new instance of the ModifyExperiment class.
        /// </summary>
        public ModifyExperiment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModifyExperiment class.
        /// </summary>
        public ModifyExperiment(string description = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? archive = default(bool?))
        {
            Description = description;
            Tags = tags;
            Archive = archive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "archive")]
        public bool? Archive { get; set; }

    }
}
