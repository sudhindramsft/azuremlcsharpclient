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
    /// Contains list of Artifact Paths.
    /// </summary>
    public partial class ArtifactPathList
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactPathList class.
        /// </summary>
        public ArtifactPathList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactPathList class.
        /// </summary>
        /// <param name="paths">List of Artifact Paths.</param>
        public ArtifactPathList(IList<ArtifactPath> paths)
        {
            Paths = paths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Artifact Paths.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<ArtifactPath> Paths { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Paths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Paths");
            }
            if (Paths != null)
            {
                foreach (var element in Paths)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
