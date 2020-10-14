namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Rating : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Rating";

        [DataMember(Name = "author", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Author { get; set; }

        [DataMember(Name = "bestRating", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> BestRating { get; set; }

        [DataMember(Name = "ratingExplanation", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> RatingExplanation { get; set; }

        [DataMember(Name = "ratingValue", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> RatingValue { get; set; }

        [DataMember(Name = "reviewAspect", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ReviewAspect { get; set; }

        [DataMember(Name = "worstRating", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> WorstRating { get; set; }
    }
}
