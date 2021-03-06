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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BatchEventCommand
    {
        /// <summary>
        /// Initializes a new instance of the BatchEventCommand class.
        /// </summary>
        public BatchEventCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchEventCommand class.
        /// </summary>
        public BatchEventCommand(IList<BaseEvent> events = default(IList<BaseEvent>))
        {
            Events = events;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<BaseEvent> Events { get; set; }

    }
}
