// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a VM size.
    /// </summary>
    public partial class VirtualMachineSize
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        public VirtualMachineSize()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineSize class.
        /// </summary>
        /// <param name="name">Virtual Machine size name</param>
        /// <param name="family">Virtual Machine family name</param>
        /// <param name="vCPUs">Number of vPUs</param>
        /// <param name="gpus">Number of gPUs</param>
        /// <param name="osVhdSizeMB">OS VHD Disk size</param>
        /// <param name="maxResourceVolumeMB">Resource volume size</param>
        /// <param name="memoryGB">Memory size</param>
        /// <param name="lowPriorityCapable">Low priority capable</param>
        /// <param name="premiumIO">Premium IO supported</param>
        public VirtualMachineSize(string name = default(string), string family = default(string), int? vCPUs = default(int?), int? gpus = default(int?), int? osVhdSizeMB = default(int?), int? maxResourceVolumeMB = default(int?), double? memoryGB = default(double?), bool? lowPriorityCapable = default(bool?), bool? premiumIO = default(bool?))
        {
            Name = name;
            Family = family;
            VCPUs = vCPUs;
            Gpus = gpus;
            OsVhdSizeMB = osVhdSizeMB;
            MaxResourceVolumeMB = maxResourceVolumeMB;
            MemoryGB = memoryGB;
            LowPriorityCapable = lowPriorityCapable;
            PremiumIO = premiumIO;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets virtual Machine size name
        /// </summary>
        /// <remarks>
        /// The name of the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets virtual Machine family name
        /// </summary>
        /// <remarks>
        /// The family name of the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; private set; }

        /// <summary>
        /// Gets number of vPUs
        /// </summary>
        /// <remarks>
        /// The number of vCPUs supported by the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "vCPUs")]
        public int? VCPUs { get; private set; }

        /// <summary>
        /// Gets number of gPUs
        /// </summary>
        /// <remarks>
        /// The number of gPUs supported by the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "gpus")]
        public int? Gpus { get; private set; }

        /// <summary>
        /// Gets OS VHD Disk size
        /// </summary>
        /// <remarks>
        /// The OS VHD disk size, in MB, allowed by the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "osVhdSizeMB")]
        public int? OsVhdSizeMB { get; private set; }

        /// <summary>
        /// Gets resource volume size
        /// </summary>
        /// <remarks>
        /// The resource volume size, in MB, allowed by the virtual machine
        /// size.
        /// </remarks>
        [JsonProperty(PropertyName = "maxResourceVolumeMB")]
        public int? MaxResourceVolumeMB { get; private set; }

        /// <summary>
        /// Gets memory size
        /// </summary>
        /// <remarks>
        /// The amount of memory, in GB, supported by the virtual machine size.
        /// </remarks>
        [JsonProperty(PropertyName = "memoryGB")]
        public double? MemoryGB { get; private set; }

        /// <summary>
        /// Gets low priority capable
        /// </summary>
        /// <remarks>
        /// Specifies if the virtual machine size supports low priority VMs.
        /// </remarks>
        [JsonProperty(PropertyName = "lowPriorityCapable")]
        public bool? LowPriorityCapable { get; private set; }

        /// <summary>
        /// Gets premium IO supported
        /// </summary>
        /// <remarks>
        /// Specifies if the virtual machine size supports premium IO.
        /// </remarks>
        [JsonProperty(PropertyName = "premiumIO")]
        public bool? PremiumIO { get; private set; }

    }
}
