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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataStoreMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataStoreMode
    {
        [EnumMember(Value = "Mount")]
        Mount,
        [EnumMember(Value = "Download")]
        Download,
        [EnumMember(Value = "Upload")]
        Upload
    }
    internal static class DataStoreModeEnumExtension
    {
        internal static string ToSerializedValue(this DataStoreMode? value)
        {
            return value == null ? null : ((DataStoreMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DataStoreMode value)
        {
            switch( value )
            {
                case DataStoreMode.Mount:
                    return "Mount";
                case DataStoreMode.Download:
                    return "Download";
                case DataStoreMode.Upload:
                    return "Upload";
            }
            return null;
        }

        internal static DataStoreMode? ParseDataStoreMode(this string value)
        {
            switch( value )
            {
                case "Mount":
                    return DataStoreMode.Mount;
                case "Download":
                    return DataStoreMode.Download;
                case "Upload":
                    return DataStoreMode.Upload;
            }
            return null;
        }
    }
}
