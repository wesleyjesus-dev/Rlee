using System.Text.Json;
using System.Text.Json.Serialization;
using RLee.Core.Frontend.Material;

namespace RLee.Core.Backend.Converters
{
    public class ScaffoldJsonConverter : JsonConverter<Scaffold>
    {
        public override Scaffold? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, Scaffold value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}

