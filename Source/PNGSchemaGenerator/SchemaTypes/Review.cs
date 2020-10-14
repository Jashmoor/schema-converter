namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Review : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Review";

        [DataMember(Name = "itemReviewed", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> ItemReviewed { get; set; }

        [DataMember(Name = "reviewAspect", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ReviewAspect { get; set; }

        [DataMember(Name = "reviewBody", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ReviewBody { get; set; }

        [DataMember(Name = "reviewRating", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Rating> ReviewRating { get; set; }
    }
}
