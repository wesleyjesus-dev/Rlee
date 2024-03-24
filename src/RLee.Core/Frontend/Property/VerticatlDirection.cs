using System.Text.Json.Serialization;


/// <summary>
/// https://api.flutter.dev/flutter/painting/VerticalDirection.html
/// </summary>
namespace RLee.Core.Frontend.Property;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerticalDirection
{
    Up,
    Down
}