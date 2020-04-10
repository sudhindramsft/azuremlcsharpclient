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

    [Newtonsoft.Json.JsonObject("IOT")]
    public partial class CreateIotServiceRequest : CreateServiceRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateIotServiceRequest class.
        /// </summary>
        public CreateIotServiceRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateIotServiceRequest class.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <param name="description">The description of the service.</param>
        /// <param name="kvTags">The service tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The service properties dictionary.
        /// Properties are immutable.</param>
        /// <param name="keys">The authentication keys.</param>
        /// <param name="deploymentType">The deployment type for the service.
        /// Possible values include: 'GRPCRealtimeEndpoint',
        /// 'HttpRealtimeEndpoint', 'Batch'</param>
        /// <param name="imageId">The Image Id.</param>
        /// <param name="environmentImageRequest">The Environment, models and
        /// assets needed for inferencing.</param>
        /// <param name="location">The location of the service.</param>
        public CreateIotServiceRequest(string name, string description = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), AuthKeys keys = default(AuthKeys), DeploymentType? deploymentType = default(DeploymentType?), string imageId = default(string), EnvironmentImageRequest environmentImageRequest = default(EnvironmentImageRequest), string location = default(string), string iotDeviceId = default(string), IDictionary<string, string> routes = default(IDictionary<string, string>), IList<IotModuleSettings> iotEdgeUserModule = default(IList<IotModuleSettings>), IotBaseModuleSettings iotEdgeModule = default(IotBaseModuleSettings), string computeName = default(string), IList<RegistryInfo> acrCredentials = default(IList<RegistryInfo>), bool? authEnabled = default(bool?))
            : base(name, description, kvTags, properties, keys, deploymentType, imageId, environmentImageRequest, location)
        {
            IotDeviceId = iotDeviceId;
            Routes = routes;
            IotEdgeUserModule = iotEdgeUserModule;
            IotEdgeModule = iotEdgeModule;
            ComputeName = computeName;
            AcrCredentials = acrCredentials;
            AuthEnabled = authEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iotDeviceId")]
        public string IotDeviceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IDictionary<string, string> Routes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iotEdgeUserModule")]
        public IList<IotModuleSettings> IotEdgeUserModule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iotEdgeModule")]
        public IotBaseModuleSettings IotEdgeModule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "computeName")]
        public string ComputeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acrCredentials")]
        public IList<RegistryInfo> AcrCredentials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authEnabled")]
        public bool? AuthEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AcrCredentials != null)
            {
                foreach (var element in AcrCredentials)
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