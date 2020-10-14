namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ContactPoint : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPoint";

        [DataMember(Name = "availableLanguage", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Language> AvailableLanguage { get; set; }

        [DataMember(Name = "contactPointOption", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPointOption?> ContactPointOption { get; set; }

        ///<inheritdoc/>
        [DataMember(Name = "contactType", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactType?> ContactType { get; set; }

        [DataMember(Name = "email", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "faxNumber", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "hoursAvailable", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OpeningHoursSpecification> HoursAvailble { get; set; }

        [DataMember(Name = "productSupported", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, string> ProductSupported { get; set; }

        [DataMember(Name = "telephone", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Telephone { get; set; }
    }
}
