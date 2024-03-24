using System.Text.Json.Serialization;


/// <summary>
/// https://api.flutter.dev/flutter/widgets/Flex/textDirection.html
/// </summary>
namespace RLee.Core.Frontend.Property;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TextDirection
{
    Rtl,
    Ltr
}