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
    /// The base service response. The correct inherited response based on
    /// computeType will be returned (ex. ACIServiceResponse)
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServiceResponseBase")]
    public partial class ServiceResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResponseBase class.
        /// </summary>
        public ServiceResponseBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResponseBase class.
        /// </summary>
        /// <param name="id">The service Id.</param>
        /// <param name="name">The service name.</param>
        /// <param name="description">The service description.</param>
        /// <param name="kvTags">The service tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The service property dictionary.
        /// Properties are immutable.</param>
        /// <param name="operationId">The ID of the latest asynchronous
        /// operation for this service.</param>
        /// <param name="state">The current state of the service. Possible
        /// values include: 'Transitioning', 'Healthy', 'Unhealthy',
        /// 'Failed'</param>
        /// <param name="createdTime">The time the service was created.</param>
        /// <param name="updatedTime">The time the service was updated.</param>
        /// <param name="error">The error details.</param>
        /// <param name="deploymentType">The deployment type for the service.
        /// Possible values include: 'GRPCRealtimeEndpoint',
        /// 'HttpRealtimeEndpoint', 'Batch'</param>
        public ServiceResponseBase(string id = default(string), string name = default(string), string description = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), string operationId = default(string), WebServiceState? state = default(WebServiceState?), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? updatedTime = default(System.DateTime?), ModelErrorResponse error = default(ModelErrorResponse), DeploymentType? deploymentType = default(DeploymentType?))
        {
            Id = id;
            Name = name;
            Description = description;
            KvTags = kvTags;
            Properties = properties;
            OperationId = operationId;
            State = state;
            CreatedTime = createdTime;
            UpdatedTime = updatedTime;
            Error = error;
            DeploymentType = deploymentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the service description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the service tag dictionary. Tags are mutable.
        /// </summary>
        [JsonProperty(PropertyName = "kvTags")]
        public IDictionary<string, string> KvTags { get; set; }

        /// <summary>
        /// Gets or sets the service property dictionary. Properties are
        /// immutable.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the ID of the latest asynchronous operation for this
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the service. Possible values
        /// include: 'Transitioning', 'Healthy', 'Unhealthy', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public WebServiceState? State { get; set; }

        /// <summary>
        /// Gets or sets the time the service was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the time the service was updated.
        /// </summary>
        [JsonProperty(PropertyName = "updatedTime")]
        public System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ModelErrorResponse Error { get; set; }

        /// <summary>
        /// Gets or sets the deployment type for the service. Possible values
        /// include: 'GRPCRealtimeEndpoint', 'HttpRealtimeEndpoint', 'Batch'
        /// </summary>
        [JsonProperty(PropertyName = "deploymentType")]
        public DeploymentType? DeploymentType { get; set; }

    }
}
