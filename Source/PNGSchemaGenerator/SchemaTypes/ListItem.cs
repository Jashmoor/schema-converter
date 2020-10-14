namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ListItem : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        [DataMember(Name = "item", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Item { get; set; }

        [DataMember(Name = "nextItem", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ListItem> NextItem { get; set; }

        [DataMember(Name = "position", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, string> Position { get; set; }

        [DataMember(Name = "previousItem", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ListItem> PreviousItem { get; set; }
    }
}
