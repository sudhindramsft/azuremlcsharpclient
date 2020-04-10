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

    /// <summary>
    /// The Json Patch definition.
    /// </summary>
    public partial class JsonPatchOperation
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchOperation class.
        /// </summary>
        public JsonPatchOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonPatchOperation class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="path">The target location.</param>
        /// <param name="op">The operation.</param>
        /// <param name="fromProperty">The source location.</param>
        public JsonPatchOperation(object value = default(object), string path = default(string), string op = default(string), string fromProperty = default(string))
        {
            Value = value;
            Path = path;
            Op = op;
            FromProperty = fromProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the target location.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string Op { get; set; }

        /// <summary>
        /// Gets or sets the source location.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string FromProperty { get; set; }

    }
}
