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

    public partial class RegenerateServiceKeysRequest
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateServiceKeysRequest
        /// class.
        /// </summary>
        public RegenerateServiceKeysRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateServiceKeysRequest
        /// class.
        /// </summary>
        /// <param name="keyType">Specification for which type of key to
        /// generate.</param>
        /// <param name="keyValue">The value the key is set to.</param>
        public RegenerateServiceKeysRequest(int? keyType = default(int?), string keyValue = default(string))
        {
            KeyType = keyType;
            KeyValue = keyValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specification for which type of key to generate.
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public int? KeyType { get; set; }

        /// <summary>
        /// Gets or sets the value the key is set to.
        /// </summary>
        [JsonProperty(PropertyName = "keyValue")]
        public string KeyValue { get; set; }

    }
}