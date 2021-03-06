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
    using System.Linq;

    public partial class RunDefinition
    {
        /// <summary>
        /// Initializes a new instance of the RunDefinition class.
        /// </summary>
        public RunDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunDefinition class.
        /// </summary>
        /// <param name="configuration">Fully specified configuration
        /// information for the run. Even when that information
        /// is contained in configuration files within the project folder, the
        /// client collapses
        /// it all and inlines it into the run definition when submitting a
        /// run.</param>
        /// <param name="snapshotId">Snapshots are user project folders that
        /// have been uploaded to the cloud for subsequent
        /// execution. This field is required when executing against
        /// cloud-based compute targets
        /// unless the run submission was against the API endpoint that takes a
        /// zipped project folder
        /// inline with the request.</param>
        /// <param name="parentRunId">Specifies that the run history entry for
        /// this execution should be scoped within
        /// an existing run as a child. Defaults to null, meaning the run has
        /// no parent.
        /// This is intended for first-party service integration, not
        /// third-party API users.</param>
        /// <param name="runType">Specifies the runsource property for this
        /// run. The default value is "experiment" if not specified.</param>
        public RunDefinition(RunConfiguration configuration = default(RunConfiguration), System.Guid? snapshotId = default(System.Guid?), string parentRunId = default(string), string runType = default(string))
        {
            Configuration = configuration;
            SnapshotId = snapshotId;
            ParentRunId = parentRunId;
            RunType = runType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully specified configuration information for the run.
        /// Even when that information
        /// is contained in configuration files within the project folder, the
        /// client collapses
        /// it all and inlines it into the run definition when submitting a
        /// run.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public RunConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets snapshots are user project folders that have been
        /// uploaded to the cloud for subsequent
        /// execution. This field is required when executing against
        /// cloud-based compute targets
        /// unless the run submission was against the API endpoint that takes a
        /// zipped project folder
        /// inline with the request.
        /// </summary>
        [JsonProperty(PropertyName = "snapshotId")]
        public System.Guid? SnapshotId { get; set; }

        /// <summary>
        /// Gets or sets specifies that the run history entry for this
        /// execution should be scoped within
        /// an existing run as a child. Defaults to null, meaning the run has
        /// no parent.
        /// This is intended for first-party service integration, not
        /// third-party API users.
        /// </summary>
        [JsonProperty(PropertyName = "parentRunId")]
        public string ParentRunId { get; set; }

        /// <summary>
        /// Gets or sets specifies the runsource property for this run. The
        /// default value is "experiment" if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "runType")]
        public string RunType { get; set; }

    }
}
