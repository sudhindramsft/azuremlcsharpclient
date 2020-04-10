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

    /// <summary>
    /// The definition of a Run.
    /// </summary>
    public partial class Run
    {
        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        public Run()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        /// <param name="experimentId">The Id of the experiment that created
        /// this run.</param>
        /// <param name="createdUtc">The time the run was created in
        /// UTC.</param>
        /// <param name="createdBy">The details of the user who created the
        /// run.</param>
        /// <param name="userId">The Id of the user that created the
        /// run.</param>
        /// <param name="token">A token used for authenticating a run.</param>
        /// <param name="tokenExpiryTimeUtc">The Token expiration time in
        /// UTC.</param>
        /// <param name="error">If an error occurred during the run, this will
        /// be populated.</param>
        /// <param name="warnings">A list of warnings that occurred during the
        /// run.</param>
        /// <param name="runId">The identifier for the run. Run IDs must be
        /// less than 256 characters and contain only alphanumeric characters
        /// with dashes and underscores.</param>
        /// <param name="parentRunId">The parent of the run if the run is
        /// hierarchical; otherwise, Null.</param>
        /// <param name="status">The status of the run. The Status string value
        /// maps to the RunStatus Enum.</param>
        /// <param name="startTimeUtc">The start time of the run in
        /// UTC.</param>
        /// <param name="endTimeUtc">The end time of the run in UTC.</param>
        public Run(int? runNumber = default(int?), string rootRunId = default(string), string experimentId = default(string), System.DateTime? createdUtc = default(System.DateTime?), CreatedBy createdBy = default(CreatedBy), string userId = default(string), string token = default(string), System.DateTime? tokenExpiryTimeUtc = default(System.DateTime?), ErrorResponse error = default(ErrorResponse), IList<RunDetailsWarning> warnings = default(IList<RunDetailsWarning>), int? revision = default(int?), string runId = default(string), string parentRunId = default(string), string status = default(string), System.DateTime? startTimeUtc = default(System.DateTime?), System.DateTime? endTimeUtc = default(System.DateTime?), bool? heartbeatEnabled = default(bool?), RunOptions options = default(RunOptions), string name = default(string), string dataContainerId = default(string), string description = default(string), bool? hidden = default(bool?), string runType = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>), string scriptName = default(string), string target = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), object runDefinition = default(object), CreatedFrom createdFrom = default(CreatedFrom), string cancelUri = default(string), string diagnosticsUri = default(string))
        {
            RunNumber = runNumber;
            RootRunId = rootRunId;
            ExperimentId = experimentId;
            CreatedUtc = createdUtc;
            CreatedBy = createdBy;
            UserId = userId;
            Token = token;
            TokenExpiryTimeUtc = tokenExpiryTimeUtc;
            Error = error;
            Warnings = warnings;
            Revision = revision;
            RunId = runId;
            ParentRunId = parentRunId;
            Status = status;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            HeartbeatEnabled = heartbeatEnabled;
            Options = options;
            Name = name;
            DataContainerId = dataContainerId;
            Description = description;
            Hidden = hidden;
            RunType = runType;
            Properties = properties;
            ScriptName = scriptName;
            Target = target;
            Tags = tags;
            RunDefinition = runDefinition;
            CreatedFrom = createdFrom;
            CancelUri = cancelUri;
            DiagnosticsUri = diagnosticsUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runNumber")]
        public int? RunNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootRunId")]
        public string RootRunId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the experiment that created this run.
        /// </summary>
        [JsonProperty(PropertyName = "experimentId")]
        public string ExperimentId { get; set; }

        /// <summary>
        /// Gets or sets the time the run was created in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "createdUtc")]
        public System.DateTime? CreatedUtc { get; set; }

        /// <summary>
        /// Gets or sets the details of the user who created the run.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Id of the user that created the run.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a token used for authenticating a run.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the Token expiration time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "tokenExpiryTimeUtc")]
        public System.DateTime? TokenExpiryTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets if an error occurred during the run, this will be
        /// populated.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Gets or sets a list of warnings that occurred during the run.
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<RunDetailsWarning> Warnings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the run. Run IDs must be less than
        /// 256 characters and contain only alphanumeric characters with dashes
        /// and underscores.
        /// </summary>
        [JsonProperty(PropertyName = "runId")]
        public string RunId { get; set; }

        /// <summary>
        /// Gets or sets the parent of the run if the run is hierarchical;
        /// otherwise, Null.
        /// </summary>
        [JsonProperty(PropertyName = "parentRunId")]
        public string ParentRunId { get; set; }

        /// <summary>
        /// Gets or sets the status of the run. The Status string value maps to
        /// the RunStatus Enum.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the start time of the run in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "startTimeUtc")]
        public System.DateTime? StartTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the end time of the run in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "endTimeUtc")]
        public System.DateTime? EndTimeUtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "heartbeatEnabled")]
        public bool? HeartbeatEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public RunOptions Options { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataContainerId")]
        public string DataContainerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runType")]
        public string RunType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scriptName")]
        public string ScriptName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runDefinition")]
        public object RunDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdFrom")]
        public CreatedFrom CreatedFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelUri")]
        public string CancelUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsUri")]
        public string DiagnosticsUri { get; set; }

    }
}
