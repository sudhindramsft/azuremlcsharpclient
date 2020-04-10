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

    /// <summary>
    /// Describes The zonal capabilities of a SKU.
    /// </summary>
    public partial class ResourceSkuZoneDetails
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuZoneDetails class.
        /// </summary>
        public ResourceSkuZoneDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuZoneDetails class.
        /// </summary>
        /// <param name="name">The set of zones that the SKU is available in
        /// with the specified capabilities.</param>
        /// <param name="capabilities">A list of capabilities that are
        /// available for the SKU in the specified list of zones.</param>
        public ResourceSkuZoneDetails(IList<string> name = default(IList<string>), IList<SKUCapability> capabilities = default(IList<SKUCapability>))
        {
            Name = name;
            Capabilities = capabilities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the set of zones that the SKU is available in with the
        /// specified capabilities.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IList<string> Name { get; private set; }

        /// <summary>
        /// Gets a list of capabilities that are available for the SKU in the
        /// specified list of zones.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<SKUCapability> Capabilities { get; private set; }

    }
}