using System.Text.Json.Serialization;
using RLee.Core.Frontend.Material;

namespace RLee.Core.Frontend
{
    [JsonDerivedType(typeof(Column))]
    [JsonDerivedType(typeof(Scaffold))]
    [JsonDerivedType(typeof(AppBar))]
    [JsonDerivedType(typeof(Row))]
    public abstract class Widget
    {
        [JsonPropertyName("$type")]
        public string Type => GetName();
        public Widget() => Key = Guid.NewGuid().ToString();
        public Widget(string key) => Key = key;
        public string Key { get; set; }
        public abstract string GetName();
    }
}

