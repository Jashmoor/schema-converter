namespace PNGSchemaGenerator.Utilities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections;

    public class SchemaJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(IValues);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return "Not implemented";
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var values = (IValues)value;
            if (values.Count == 0)
            {
                serializer.Serialize(writer, null);
            }
            if (values.Count == 1)
            {
                IEnumerator enumerator = values.GetEnumerator();
                enumerator.MoveNext();
                serializer.Serialize(writer, enumerator.Current);
            }
            if (values.Count > 1)
            {
                writer.WriteStartArray();
                foreach (var item in values)
                {
                    serializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
        }
    }
}
