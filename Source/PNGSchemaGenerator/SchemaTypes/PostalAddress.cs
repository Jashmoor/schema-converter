namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PostalAddress : ContactPoint
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostalAddress";

        [DataMember(Name = "addressCountry", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Country, string> AddressCountry { get; set; }

        [DataMember(Name = "addressLocality", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AddressLocality { get; set; }

        [DataMember(Name = "addressRegion", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AddressRegion { get; set; }

        [DataMember(Name = "postalCode", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PostalCode { get; set; }

        [DataMember(Name = "postOfficeBoxNumber", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PostOfficeBoxNumber { get; set; }

        [DataMember(Name = "streetAddress", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> StreetAddress { get; set; }
    }
}
