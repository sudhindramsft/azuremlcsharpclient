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
    /// A private link resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        public PrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        /// <param name="id">Specifies the resource ID.</param>
        /// <param name="name">Specifies the name of the resource.</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="location">Specifies the location of the
        /// resource.</param>
        /// <param name="type">Specifies the type of the resource.</param>
        /// <param name="tags">Contains resource tags defined as key/value
        /// pairs.</param>
        /// <param name="sku">The sku of the workspace.</param>
        /// <param name="groupId">The private link resource group id.</param>
        /// <param name="requiredMembers">The private link resource required
        /// member names.</param>
        /// <param name="requiredZoneNames">The private link resource Private
        /// link DNS zone name.</param>
        public PrivateLinkResource(string id = default(string), string name = default(string), Identity identity = default(Identity), string location = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string groupId = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>))
            : base(id, name, identity, location, type, tags, sku)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the private link resource group id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets the private link resource required member names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredMembers")]
        public IList<string> RequiredMembers { get; private set; }

        /// <summary>
        /// Gets or sets the private link resource Private link DNS zone name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; set; }

    }
}
