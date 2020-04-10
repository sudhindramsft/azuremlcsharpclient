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
    /// Part of request for HyperDrive_CreateExperiment. Contains configuration
    /// details required to create hyperdrive run.
    /// </summary>
    public partial class HyperDriveCreateExperiment : HyperDriveExperimentBase
    {
        /// <summary>
        /// Initializes a new instance of the HyperDriveCreateExperiment class.
        /// </summary>
        public HyperDriveCreateExperiment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HyperDriveCreateExperiment class.
        /// </summary>
        /// <param name="generatorConfig">Hyperparameter space and the sampling
        /// method configuration.</param>
        /// <param name="name">Name of the Hyperdrive run.</param>
        /// <param name="platformConfig">Platform config object specifying the
        /// run definition structure.</param>
        /// <param name="policyConfig">Early termination policy
        /// configuration.</param>
        /// <param name="primaryMetricConfig">Name of the primary metric and
        /// goal of optimizing.</param>
        /// <param name="user">User who is creating the Hyperdrive run.</param>
        /// <param name="description">The description for Hyperdrive
        /// run.</param>
        /// <param name="maxConcurrentJobs">Maximum number of runs to run
        /// concurrently.</param>
        /// <param name="maxDurationMinutes">Maximum duration of the Hyperdrive
        /// run.</param>
        /// <param name="maxTotalJobs">Maximum number of runs.</param>
        /// <param name="studyId">Study Id of the Hyperdrive run.</param>
        public HyperDriveCreateExperiment(HyperDriveExperimentBaseGeneratorConfig generatorConfig, string name, object platformConfig, HyperDrivePolicyConfigBase policyConfig, HyperDriveExperimentBasePrimaryMetricConfig primaryMetricConfig, string user, string description = default(string), int? maxConcurrentJobs = default(int?), int? maxDurationMinutes = default(int?), int? maxTotalJobs = default(int?), int? studyId = default(int?))
            : base(generatorConfig, name, platformConfig, policyConfig, primaryMetricConfig, description, maxConcurrentJobs, maxDurationMinutes, maxTotalJobs, studyId)
        {
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user who is creating the Hyperdrive run.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
            if (User != null)
            {
                if (User.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "User", 255);
                }
            }
        }
    }
}