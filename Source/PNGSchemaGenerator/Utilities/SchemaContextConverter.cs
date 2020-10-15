namespace PNGSchemaGenerator.Utilities
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.SchemaTypes;
    using System;

    public class SchemaContextConverter : JsonConverter<JsonBaseContext>
    {
        public override JsonBaseContext ReadJson(JsonReader reader, Type objectType, JsonBaseContext existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, JsonBaseContext value, JsonSerializer serializer)
        {
            if (writer == null)
                return;
            if (value == null)
                return;
            if (serializer == null)
                return;

            if (string.IsNullOrWhiteSpace(value.Language))
            {
                writer.WriteValue(value.Name);
            }
            else
            {
                writer.WriteStartObject();
                writer.WritePropertyName("name");
                writer.WriteValue(value.Name);
                writer.WritePropertyName("@language");
                writer.WriteValue(value.Language);
                writer.WriteEndObject();
            }
        }
    }
}
