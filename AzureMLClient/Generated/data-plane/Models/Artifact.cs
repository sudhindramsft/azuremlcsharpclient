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
    using System.Linq;

    /// <summary>
    /// Details of an Artifact.
    /// </summary>
    public partial class Artifact
    {
        /// <summary>
        /// Initializes a new instance of the Artifact class.
        /// </summary>
        public Artifact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Artifact class.
        /// </summary>
        /// <param name="origin">The origin of the Artifact creation request.
        /// Available origins are 'ExperimentRun', 'LocalUpload', 'WebUpload',
        /// 'Dataset' and 'Unknown'.</param>
        /// <param name="container">The name of container. Artifacts can be
        /// grouped by container.</param>
        /// <param name="path">The path to the Artifact in a container.</param>
        /// <param name="artifactId">The identifier of an Artifact. Format of
        /// ArtifactId - {Origin}/{Container}/{Path}.</param>
        /// <param name="etag">The Etag of the Artifact.</param>
        /// <param name="createdTime">The Date and Time at which the Artifact
        /// is created. The DateTime is in UTC.</param>
        public Artifact(string origin, string container, string path, string artifactId = default(string), string etag = default(string), System.DateTime? createdTime = default(System.DateTime?), DataPath dataPath = default(DataPath))
        {
            ArtifactId = artifactId;
            Origin = origin;
            Container = container;
            Path = path;
            Etag = etag;
            CreatedTime = createdTime;
            DataPath = dataPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier of an Artifact. Format of ArtifactId -
        /// {Origin}/{Container}/{Path}.
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the origin of the Artifact creation request. Available
        /// origins are 'ExperimentRun', 'LocalUpload', 'WebUpload', 'Dataset'
        /// and 'Unknown'.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the name of container. Artifacts can be grouped by
        /// container.
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets the path to the Artifact in a container.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets the Etag of the Artifact.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the Date and Time at which the Artifact is created. The
        /// DateTime is in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataPath")]
        public DataPath DataPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Origin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Origin");
            }
            if (Container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Container");
            }
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}
