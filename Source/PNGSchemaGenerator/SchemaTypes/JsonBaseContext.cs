namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    public class JsonBaseContext
    {
        [DataMember(Name = "name", Order = 0)]
        public string Name { get; set; } = "https://schema.org";

        [DataMember(Name = "language", Order = 1)]
        public string Language { get; set; }

        public static implicit operator string(JsonBaseContext context) => context.Name;
        public override string ToString() => Name;

    }
}
