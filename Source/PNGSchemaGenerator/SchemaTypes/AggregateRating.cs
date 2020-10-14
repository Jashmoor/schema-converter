namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AggregateRating : Rating
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateRating";

        [DataMember(Name = "itemReviewed", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> ItemReviewed { get; set; }

        [DataMember(Name = "ratingCount", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> RatingCount { get; set; }

        [DataMember(Name = "reviewCount", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> ReviewCount { get; set; }
    }
}
