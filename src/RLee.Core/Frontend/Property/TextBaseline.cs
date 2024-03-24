using System.Text.Json.Serialization;


/// <summary>
/// https://api.flutter.dev/flutter/dart-ui/Clip.html
/// </summary>
namespace RLee.Core.Frontend.Property;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TextBaseline
{
    Alphabetic,
    Ideographic
}