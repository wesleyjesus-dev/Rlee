using System;
using System.Text.Json.Serialization;
namespace RLee.Core.Frontend.Property
{
    /// <summary>
    /// https://api.flutter.dev/flutter/rendering/MainAxisSize.html
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MainAxisSize
	{
		Min,
		Max,
	}
}

