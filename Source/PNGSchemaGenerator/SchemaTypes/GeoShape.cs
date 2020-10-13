namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class GeoShape : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoShape";

        [DataMember(Name = "address", Order = 2)]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "addressCountry", Order = 3)]
        public Either<Country, string> AddressCountry { get; set; }

        [DataMember(Name = "box", Order = 4)]
        public OneOrMore<string> Box { get; set; }

        [DataMember(Name = "circle", Order = 5)]
        public OneOrMore<string> Circle { get; set; }

        [DataMember(Name = "elevation", Order = 6)]
        public Either<double?, string> Elevation { get; set; }

        [DataMember(Name = "line", Order = 7)]
        public OneOrMore<string> Line { get; set; }

        [DataMember(Name = "polygon", Order = 8)]
        public OneOrMore<string> Polygon { get; set; }

        [DataMember(Name = "postalCode", Order = 9)]
        public OneOrMore<string> PostalCode { get; set; }
    }
}
