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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request for creating a profile.
    /// </summary>
    public partial class ProfileRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the ProfileRequestBase class.
        /// </summary>
        public ProfileRequestBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProfileRequestBase class.
        /// </summary>
        /// <param name="name">The profile name.</param>
        /// <param name="description">The profile description.</param>
        /// <param name="inputData">The profile input data.</param>
        /// <param name="kvTags">The tags dictionary.</param>
        /// <param name="properties">The properties dictionary.</param>
        public ProfileRequestBase(string name, string description = default(string), string inputData = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            Name = name;
            Description = description;
            InputData = inputData;
            KvTags = kvTags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the profile description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the profile input data.
        /// </summary>
        [JsonProperty(PropertyName = "inputData")]
        public string InputData { get; set; }

        /// <summary>
        /// Gets or sets the tags dictionary.
        /// </summary>
        [JsonProperty(PropertyName = "kvTags")]
        public IDictionary<string, string> KvTags { get; set; }

        /// <summary>
        /// Gets or sets the properties dictionary.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}