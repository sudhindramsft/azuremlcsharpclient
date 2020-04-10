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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The quota assigned to a resource.
    /// </summary>
    public partial class ResourceQuota
    {
        /// <summary>
        /// Initializes a new instance of the ResourceQuota class.
        /// </summary>
        public ResourceQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceQuota class.
        /// </summary>
        /// <param name="id">Specifies the resource ID.</param>
        /// <param name="type">Specifies the resource type.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="unit">An enum describing the unit of quota
        /// measurement. Possible values include: 'Count'</param>
        public ResourceQuota(string id = default(string), string type = default(string), ResourceName name = default(ResourceName), long? limit = default(long?), string unit = default(string))
        {
            Id = id;
            Type = type;
            Name = name;
            Limit = limit;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets specifies the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public ResourceName Name { get; private set; }

        /// <summary>
        /// Gets limit.
        /// </summary>
        /// <remarks>
        /// The maximum permitted quota of the resource.
        /// </remarks>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; private set; }

        /// <summary>
        /// Gets an enum describing the unit of quota measurement. Possible
        /// values include: 'Count'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

    }
}