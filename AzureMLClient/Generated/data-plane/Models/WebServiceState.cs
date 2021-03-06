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
    /// Defines values for WebServiceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebServiceState
    {
        [EnumMember(Value = "Transitioning")]
        Transitioning,
        [EnumMember(Value = "Healthy")]
        Healthy,
        [EnumMember(Value = "Unhealthy")]
        Unhealthy,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class WebServiceStateEnumExtension
    {
        internal static string ToSerializedValue(this WebServiceState? value)
        {
            return value == null ? null : ((WebServiceState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebServiceState value)
        {
            switch( value )
            {
                case WebServiceState.Transitioning:
                    return "Transitioning";
                case WebServiceState.Healthy:
                    return "Healthy";
                case WebServiceState.Unhealthy:
                    return "Unhealthy";
                case WebServiceState.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static WebServiceState? ParseWebServiceState(this string value)
        {
            switch( value )
            {
                case "Transitioning":
                    return WebServiceState.Transitioning;
                case "Healthy":
                    return WebServiceState.Healthy;
                case "Unhealthy":
                    return WebServiceState.Unhealthy;
                case "Failed":
                    return WebServiceState.Failed;
            }
            return null;
        }
    }
}
