namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Rating : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Rating";

        [DataMember(Name = "author", Order = 2)]
        public Either<Organization, Person> Author { get; set; }

        [DataMember(Name = "bestRating", Order = 3)]
        public Either<double?, string> BestRating { get; set; }

        [DataMember(Name = "ratingExplanation", Order = 4)]
        public OneOrMore<string> RatingExplanation { get; set; }

        [DataMember(Name = "ratingValue", Order = 5)]
        public Either<double?, string> RatingValue { get; set; }

        [DataMember(Name = "reviewAspect", Order = 6)]
        public OneOrMore<string> ReviewAspect { get; set; }

        [DataMember(Name = "worstRating", Order = 7)]
        public Either<double?, string> WorstRating { get; set; }
    }
}
