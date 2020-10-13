namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Review : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Review";

        [DataMember(Name = "itemReviewed", Order = 2)]
        public OneOrMore<Thing> ItemReviewed { get; set; }

        [DataMember(Name = "reviewAspect", Order = 3)]
        public OneOrMore<string> ReviewAspect { get; set; }

        [DataMember(Name = "reviewBody", Order = 4)]
        public OneOrMore<string> ReviewBody { get; set; }

        [DataMember(Name = "reviewRating", Order = 5)]
        public OneOrMore<Rating> ReviewRating { get; set; }
    }
}
