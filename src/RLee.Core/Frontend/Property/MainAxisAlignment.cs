using System.Text.Json.Serialization;

namespace RLee.Core.Frontend.Property
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MainAxisAlignment
    {
        Start,
        End,
        Center,
        SpaceBetween,
        SpaceAround,
        SpaceEvenly
    }
}

