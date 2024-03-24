using System.Text.Json.Serialization;

namespace RLee.Core.Frontend.Property
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CrossAxisAlignment
    {
        Start,
        End,
        Center,
        Stretch,
        Baseline
    }
}

