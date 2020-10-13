namespace PNGSchemaGenerator.Utilities
{
    using Newtonsoft.Json;
    using System;

    public class SchemaJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(IValues);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return "Not implemented";
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (typeof(string) == value.GetType())
            {
                WriteObject(writer, value, serializer);
                return;
            }

            var values = (IValues)value;
            if (values.Count == 0)
            {
                serializer.Serialize(writer, null);
            }
            else if (values.Count == 1)
            {
                var enumerator = values.GetEnumerator();
                enumerator.MoveNext();
                WriteObject(writer, enumerator.Current, serializer);
            }
            else
            {
                writer.WriteStartArray();
                foreach (var item in values)
                {
                    WriteObject(writer, item, serializer);
                }

                writer.WriteEndArray();
            }
        }

        public virtual void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

    }
}
