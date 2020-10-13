namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AggregateRating : Rating
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateRating";

        [DataMember(Name = "itemReviewed", Order = 2)]
        public OneOrMore<Thing> ItemReviewed { get; set; }

        [DataMember(Name = "ratingCount", Order = 3)]
        public OneOrMore<int?> RatingCount { get; set; }

        [DataMember(Name = "reviewCount", Order = 4)]
        public OneOrMore<int?> ReviewCount { get; set; }
    }
}
