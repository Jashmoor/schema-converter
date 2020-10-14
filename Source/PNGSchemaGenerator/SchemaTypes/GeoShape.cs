namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class GeoShape : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoShape";

        [DataMember(Name = "address", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "addressCountry", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Country, string> AddressCountry { get; set; }

        [DataMember(Name = "box", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Box { get; set; }

        [DataMember(Name = "circle", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Circle { get; set; }

        [DataMember(Name = "elevation", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Elevation { get; set; }

        [DataMember(Name = "line", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Line { get; set; }

        [DataMember(Name = "polygon", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Polygon { get; set; }

        [DataMember(Name = "postalCode", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PostalCode { get; set; }
    }
}
