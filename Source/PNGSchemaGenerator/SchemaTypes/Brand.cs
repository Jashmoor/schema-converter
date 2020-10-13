namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Brand : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        [DataMember(Name = "aggregateRating", Order = 2)]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "logo", Order = 3)]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "review", Order = 4)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "slogan", Order = 5)]
        public OneOrMore<string> Slogan { get; set; }
    }
}
