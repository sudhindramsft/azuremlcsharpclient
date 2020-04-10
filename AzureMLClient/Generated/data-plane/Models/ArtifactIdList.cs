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
    /// Contains list of Artifact Ids.
    /// </summary>
    public partial class ArtifactIdList
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactIdList class.
        /// </summary>
        public ArtifactIdList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactIdList class.
        /// </summary>
        /// <param name="artifactIds">List of Artifacts Ids.</param>
        public ArtifactIdList(IList<string> artifactIds)
        {
            ArtifactIds = artifactIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Artifacts Ids.
        /// </summary>
        [JsonProperty(PropertyName = "artifactIds")]
        public IList<string> ArtifactIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ArtifactIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ArtifactIds");
            }
        }
    }
}