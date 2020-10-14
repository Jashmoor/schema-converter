namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class GeoCoordinates : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoCoordinates";

        [DataMember(Name = "address", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "addressCountry", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Country, string> AddressCountry { get; set; }

        [DataMember(Name = "elevation", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Elevation { get; set; }

        [DataMember(Name = "latitude", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Latitude { get; set; }

        [DataMember(Name = "longitude", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Longitude { get; set; }

        [DataMember(Name = "postalCode", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PostalCode { get; set; }
    }
}
