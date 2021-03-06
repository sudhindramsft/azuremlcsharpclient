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

    [Newtonsoft.Json.JsonObject("ImageResponseBase")]
    public partial class ImageResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the ImageResponseBase class.
        /// </summary>
        public ImageResponseBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageResponseBase class.
        /// </summary>
        /// <param name="id">The image Id.</param>
        /// <param name="name">The image name.</param>
        /// <param name="version">The image version.</param>
        /// <param name="description">The image description.</param>
        /// <param name="kvTags">The image tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The image properties dictionary.
        /// Properties are immutable.</param>
        /// <param name="createdTime">The time the image was created.</param>
        /// <param name="modifiedTime">The time the image was last
        /// modified.</param>
        /// <param name="autoDelete">Whether the image will be automatically
        /// deleted with the last service using it.</param>
        /// <param name="imageType">The type of the image. Possible values
        /// include: 'Docker'</param>
        /// <param name="creationState">The state of the operation. Possible
        /// values include: 'NotStarted', 'Running', 'Cancelled', 'Succeeded',
        /// 'Failed', 'TimedOut'</param>
        /// <param name="error">The error response.</param>
        /// <param name="modelIds">The list of model Ids.</param>
        /// <param name="modelDetails">The list of models.</param>
        /// <param name="imageLocation">The Image location string.</param>
        /// <param name="imageBuildLogUri">The Uri to the image build
        /// logs.</param>
        /// <param name="operationId">The ID of the asynchronous operation for
        /// this image.</param>
        public ImageResponseBase(string id = default(string), string name = default(string), long? version = default(long?), string description = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? modifiedTime = default(System.DateTime?), bool? autoDelete = default(bool?), ImageType? imageType = default(ImageType?), AsyncOperationState? creationState = default(AsyncOperationState?), ModelErrorResponse error = default(ModelErrorResponse), IList<string> modelIds = default(IList<string>), IList<Model> modelDetails = default(IList<Model>), string imageLocation = default(string), string imageBuildLogUri = default(string), string operationId = default(string))
        {
            Id = id;
            Name = name;
            Version = version;
            Description = description;
            KvTags = kvTags;
            Properties = properties;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            AutoDelete = autoDelete;
            ImageType = imageType;
            CreationState = creationState;
            Error = error;
            ModelIds = modelIds;
            ModelDetails = modelDetails;
            ImageLocation = imageLocation;
            ImageBuildLogUri = imageBuildLogUri;
            OperationId = operationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the image Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the image name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public long? Version { get; set; }

        /// <summary>
        /// Gets or sets the image description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image tag dictionary. Tags are mutable.
        /// </summary>
        [JsonProperty(PropertyName = "kvTags")]
        public IDictionary<string, string> KvTags { get; set; }

        /// <summary>
        /// Gets or sets the image properties dictionary. Properties are
        /// immutable.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the time the image was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the time the image was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public System.DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets whether the image will be automatically deleted with
        /// the last service using it.
        /// </summary>
        [JsonProperty(PropertyName = "autoDelete")]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// Gets or sets the type of the image. Possible values include:
        /// 'Docker'
        /// </summary>
        [JsonProperty(PropertyName = "imageType")]
        public ImageType? ImageType { get; set; }

        /// <summary>
        /// Gets or sets the state of the operation. Possible values include:
        /// 'NotStarted', 'Running', 'Cancelled', 'Succeeded', 'Failed',
        /// 'TimedOut'
        /// </summary>
        [JsonProperty(PropertyName = "creationState")]
        public AsyncOperationState? CreationState { get; set; }

        /// <summary>
        /// Gets or sets the error response.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ModelErrorResponse Error { get; set; }

        /// <summary>
        /// Gets or sets the list of model Ids.
        /// </summary>
        [JsonProperty(PropertyName = "modelIds")]
        public IList<string> ModelIds { get; set; }

        /// <summary>
        /// Gets or sets the list of models.
        /// </summary>
        [JsonProperty(PropertyName = "modelDetails")]
        public IList<Model> ModelDetails { get; set; }

        /// <summary>
        /// Gets or sets the Image location string.
        /// </summary>
        [JsonProperty(PropertyName = "imageLocation")]
        public string ImageLocation { get; set; }

        /// <summary>
        /// Gets or sets the Uri to the image build logs.
        /// </summary>
        [JsonProperty(PropertyName = "imageBuildLogUri")]
        public string ImageBuildLogUri { get; set; }

        /// <summary>
        /// Gets or sets the ID of the asynchronous operation for this image.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

    }
}
