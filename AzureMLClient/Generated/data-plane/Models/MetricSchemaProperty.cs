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

    public partial class MetricSchemaProperty
    {
        /// <summary>
        /// Initializes a new instance of the MetricSchemaProperty class.
        /// </summary>
        public MetricSchemaProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSchemaProperty class.
        /// </summary>
        public MetricSchemaProperty(string propertyId = default(string), string name = default(string), string type = default(string))
        {
            PropertyId = propertyId;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyId")]
        public string PropertyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
