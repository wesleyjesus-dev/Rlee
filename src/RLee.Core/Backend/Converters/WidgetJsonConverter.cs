using System.Text.Json;
using System.Text.Json.Serialization;
using RLee.Core.Frontend;
using RLee.Core.Frontend.Material;
using RLee.Core.Frontend.Property;

namespace RLee.Core.Backend.Converters
{
    public class WidgetJsonConverter : JsonConverter<Widget>
    {
        public override Widget? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            string? propertyName = reader.GetString();
            if (propertyName != "MemberType")
                throw new JsonException();

            reader.Read();
            if (reader.TokenType != JsonTokenType.String)
                throw new JsonException();

            var widgetType = reader.GetString();
            Widget widget;
            switch(widgetType)
            {
                case "Column":
                    widget = new Column();
                    break;

                default:
                    throw new JsonException();
            }

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                    return widget;
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "Key":
                            widget.Key = reader.GetString();
                            break;

                        case "CrossAxisAlignment":
                            string crossAxisAlignment = reader.GetString();
                            if (widget is Column)
                                ((Column)widget).CrossAxisAlignment = Enum.Parse<CrossAxisAlignment>(crossAxisAlignment);
                            else
                                throw new JsonException();
                            break;

                        case "Children":
                            if (widget is Column)
                            {
                                if (reader.TokenType == JsonTokenType.StartArray)
                                {
                                    while (reader.Read())
                                    {
                                        if (reader.TokenType == JsonTokenType.EndArray)
                                            break;

                                        var children = reader.GetString();

                                        if (children != null)
                                            ((Column)widget).Children.Add(null);
                                    }
                                }
                            }
                            else
                                throw new JsonException();
                            break;
                    }
                }
            }
            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, Widget widget, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            if (widget is Scaffold)
            {
                writer.WriteString("AppBar", "");
                writer.WriteString("Body", "");
                writer.WriteString("BottomNavigationBar", "");

                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}

