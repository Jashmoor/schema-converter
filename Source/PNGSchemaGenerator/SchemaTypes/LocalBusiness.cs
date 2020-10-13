namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class LocalBusiness : OrganizationAndPlace
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusiness";

        [DataMember(Name = "currenciesAccepted", Order = 2)]
        public OneOrMore<string> CurrenciesAccepted { get; set; }

        [DataMember(Name = "openingHours", Order = 3)]
        public virtual OneOrMore<string> OpeningHours { get; set; }

        [DataMember(Name = "paymentAccepted", Order = 4)]
        public OneOrMore<string> PaymentAccepted { get; set; }

        [DataMember(Name = "priceRange", Order = 5)]
        public OneOrMore<string> PriceRange { get; set; }
    }
}
