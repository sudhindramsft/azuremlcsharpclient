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

    public partial class BatchAddOrModifyRunRequest
    {
        /// <summary>
        /// Initializes a new instance of the BatchAddOrModifyRunRequest class.
        /// </summary>
        public BatchAddOrModifyRunRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAddOrModifyRunRequest class.
        /// </summary>
        public BatchAddOrModifyRunRequest(IList<CreateRun> runs = default(IList<CreateRun>))
        {
            Runs = runs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runs")]
        public IList<CreateRun> Runs { get; set; }

    }
}