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

    public partial class CreatedBy
    {
        /// <summary>
        /// Initializes a new instance of the CreatedBy class.
        /// </summary>
        public CreatedBy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatedBy class.
        /// </summary>
        /// <param name="userObjectId">A user or service principal's object ID.
        /// This is PII and should never be logged.</param>
        /// <param name="userTenantId">A user or service principal's tenant
        /// ID.</param>
        /// <param name="userName">A user's full name or a service principal's
        /// app ID.
        /// This is PII and should never be logged.</param>
        public CreatedBy(string userObjectId = default(string), string userTenantId = default(string), string userName = default(string))
        {
            UserObjectId = userObjectId;
            UserTenantId = userTenantId;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a user or service principal's object ID.
        /// This is PII and should never be logged.
        /// </summary>
        [JsonProperty(PropertyName = "userObjectId")]
        public string UserObjectId { get; set; }

        /// <summary>
        /// Gets or sets a user or service principal's tenant ID.
        /// </summary>
        [JsonProperty(PropertyName = "userTenantId")]
        public string UserTenantId { get; set; }

        /// <summary>
        /// Gets or sets a user's full name or a service principal's app ID.
        /// This is PII and should never be logged.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

    }
}
