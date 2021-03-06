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
    /// The target runtime.
    /// </summary>
    public partial class TargetRuntime
    {
        /// <summary>
        /// Initializes a new instance of the TargetRuntime class.
        /// </summary>
        public TargetRuntime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetRuntime class.
        /// </summary>
        /// <param name="targetArchitecture">The target architecture. Possible
        /// values include: 'Amd64', 'Arm32v7'</param>
        /// <param name="osType">The target operating system. Possible values
        /// include: 'Linux', 'Windows'</param>
        /// <param name="runtimeType">The target runtime type. Possible values
        /// include: 'SparkPython', 'Tlc37', 'Tlc38', 'Tlc310', 'Python',
        /// 'PythonSlim', 'PythonCustom'</param>
        /// <param name="properties">The properties dictionary.</param>
        public TargetRuntime(ArchitectureType? targetArchitecture = default(ArchitectureType?), OSType? osType = default(OSType?), RuntimeType? runtimeType = default(RuntimeType?), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            TargetArchitecture = targetArchitecture;
            OsType = osType;
            RuntimeType = runtimeType;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target architecture. Possible values include:
        /// 'Amd64', 'Arm32v7'
        /// </summary>
        [JsonProperty(PropertyName = "targetArchitecture")]
        public ArchitectureType? TargetArchitecture { get; set; }

        /// <summary>
        /// Gets or sets the target operating system. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OSType? OsType { get; set; }

        /// <summary>
        /// Gets or sets the target runtime type. Possible values include:
        /// 'SparkPython', 'Tlc37', 'Tlc38', 'Tlc310', 'Python', 'PythonSlim',
        /// 'PythonCustom'
        /// </summary>
        [JsonProperty(PropertyName = "runtimeType")]
        public RuntimeType? RuntimeType { get; set; }

        /// <summary>
        /// Gets the properties dictionary.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; private set; }

    }
}
