namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PostalAddress : ContactPoint
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        [DataMember(Name = "addressCountry", Order = 2)]
        public Either<Country, string> AddressCountry { get; set; }

        [DataMember(Name = "addressLocality", Order = 3)]
        public OneOrMore<string> AddressLocality { get; set; }

        [DataMember(Name = "addressRegion", Order = 4)]
        public OneOrMore<string> AddressRegion { get; set; }

        [DataMember(Name = "postalCode", Order = 5)]
        public OneOrMore<string> PostalCode { get; set; }

        [DataMember(Name = "postOfficeBoxNumber", Order = 6)]
        public OneOrMore<string> PostOfficeBoxNumber { get; set; }

        [DataMember(Name = "streetAddress", Order = 7)]
        public OneOrMore<string> StreetAddress { get; set; }
    }
}
