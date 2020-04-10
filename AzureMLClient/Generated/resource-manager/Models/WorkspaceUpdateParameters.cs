// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a machine learning workspace.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkspaceUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceUpdateParameters class.
        /// </summary>
        public WorkspaceUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceUpdateParameters class.
        /// </summary>
        /// <param name="tags">The resource tags for the machine learning
        /// workspace.</param>
        /// <param name="sku">The sku of the workspace.</param>
        /// <param name="description">The description of this
        /// workspace.</param>
        /// <param name="friendlyName">The friendly name for this
        /// workspace.</param>
        public WorkspaceUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string description = default(string), string friendlyName = default(string))
        {
            Tags = tags;
            Sku = sku;
            Description = description;
            FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource tags for the machine learning workspace.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the sku of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the description of this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the friendly name for this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

    }
}
