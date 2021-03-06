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
    /// The Asset definition.
    /// </summary>
    public partial class Asset
    {
        /// <summary>
        /// Initializes a new instance of the Asset class.
        /// </summary>
        public Asset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Asset class.
        /// </summary>
        /// <param name="name">The name of the Asset.</param>
        /// <param name="id">The Asset Id.</param>
        /// <param name="description">The Asset description.</param>
        /// <param name="artifacts">A list of child artifacts.</param>
        /// <param name="kvTags">The Asset tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The Asset property dictionary. Properties
        /// are immutable.</param>
        /// <param name="runid">The RunId associated with this Asset.</param>
        /// <param name="meta">A dictionary containing metadata about the
        /// Asset.</param>
        /// <param name="createdTime">The time the Asset was created in
        /// UTC.</param>
        public Asset(string name, string id = default(string), string description = default(string), IList<ArtifactDetails> artifacts = default(IList<ArtifactDetails>), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), string runid = default(string), IDictionary<string, string> meta = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            Description = description;
            Artifacts = artifacts;
            KvTags = kvTags;
            Properties = properties;
            Runid = runid;
            Meta = meta;
            CreatedTime = createdTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Asset Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Asset.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Asset description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of child artifacts.
        /// </summary>
        [JsonProperty(PropertyName = "artifacts")]
        public IList<ArtifactDetails> Artifacts { get; set; }

        /// <summary>
        /// Gets or sets the Asset tag dictionary. Tags are mutable.
        /// </summary>
        [JsonProperty(PropertyName = "kvTags")]
        public IDictionary<string, string> KvTags { get; set; }

        /// <summary>
        /// Gets or sets the Asset property dictionary. Properties are
        /// immutable.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the RunId associated with this Asset.
        /// </summary>
        [JsonProperty(PropertyName = "runid")]
        public string Runid { get; set; }

        /// <summary>
        /// Gets or sets a dictionary containing metadata about the Asset.
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public IDictionary<string, string> Meta { get; set; }

        /// <summary>
        /// Gets the time the Asset was created in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

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
