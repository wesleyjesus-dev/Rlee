
using System.Text.Json.Serialization;


/// <summary>
/// https://api.flutter.dev/flutter/widgets/Flex/direction.html
/// </summary>
namespace RLee.Core.Frontend.Property;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Axis
{
    Horizontal,
    Vertical
}