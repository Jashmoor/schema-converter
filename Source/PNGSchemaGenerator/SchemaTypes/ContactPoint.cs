namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ContactPoint : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPoint";

        [DataMember(Name = "availableLanguage", Order = 2)]
        public OneOrMore<Language> AvailableLanguage { get; set; }

        [DataMember(Name = "contactPointOption", Order = 3)]
        public OneOrMore<ContactPointOption?> ContactPointOption { get; set; }

        ///<inheritdoc/>
        [DataMember(Name = "contactType", Order = 4)]
        public OneOrMore<ContactType?> ContactType { get; set; }

        [DataMember(Name = "email", Order = 5)]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "faxNumber", Order = 6)]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "hoursAvailable", Order = 7)]
        public OneOrMore<OpeningHoursSpecification> HoursAvailble { get; set; }

        [DataMember(Name = "productSupported", Order = 8)]
        public Either<Product, string> ProductSupported { get; set; }

        [DataMember(Name = "telephone", Order = 9)]
        public OneOrMore<string> Telephone { get; set; }
    }
}
