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
    /// Response for HyperDrive_CreateExperiment in case of success.
    /// </summary>
    public partial class HyperDriveExperimentResponse
    {
        /// <summary>
        /// Initializes a new instance of the HyperDriveExperimentResponse
        /// class.
        /// </summary>
        public HyperDriveExperimentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HyperDriveExperimentResponse
        /// class.
        /// </summary>
        /// <param name="code">Response code.</param>
        /// <param name="result">Details about created Hyperdrive run.</param>
        public HyperDriveExperimentResponse(int code, HyperDriveExperiment result)
        {
            Code = code;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets response code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets details about created Hyperdrive run.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public HyperDriveExperiment Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Result == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Result");
            }
            if (Result != null)
            {
                Result.Validate();
            }
        }
    }
}
