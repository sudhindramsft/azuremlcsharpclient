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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResourceSkuLocationInfo
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuLocationInfo class.
        /// </summary>
        public ResourceSkuLocationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuLocationInfo class.
        /// </summary>
        /// <param name="location">Location of the SKU</param>
        /// <param name="zones">List of availability zones where the SKU is
        /// supported.</param>
        /// <param name="zoneDetails">Details of capabilities available to a
        /// SKU in specific zones.</param>
        public ResourceSkuLocationInfo(string location = default(string), IList<string> zones = default(IList<string>), IList<ResourceSkuZoneDetails> zoneDetails = default(IList<ResourceSkuZoneDetails>))
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets location of the SKU
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets list of availability zones where the SKU is supported.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; private set; }

        /// <summary>
        /// Gets details of capabilities available to a SKU in specific zones.
        /// </summary>
        [JsonProperty(PropertyName = "zoneDetails")]
        public IList<ResourceSkuZoneDetails> ZoneDetails { get; private set; }

    }
}
