namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class LocalBusiness : OrganizationAndPlace
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusiness";

        [DataMember(Name = "currenciesAccepted", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CurrenciesAccepted { get; set; }

        [DataMember(Name = "openingHours", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> OpeningHours { get; set; }

        [DataMember(Name = "paymentAccepted", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PaymentAccepted { get; set; }

        [DataMember(Name = "priceRange", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PriceRange { get; set; }
    }
}
