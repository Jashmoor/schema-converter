namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PriceSpecification : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PriceSpecification";

        [DataMember(Name = "eligibleQuantity", Order = 2)]
        public OneOrMore<QuantitativeValue> EligibleQuantity { get; set; }

        [DataMember(Name = "eligibleTransactionVolume", Order = 3)]
        public OneOrMore<PriceSpecification> EligibleTransactionVolume { get; set; }

        [DataMember(Name = "maxPrice", Order = 4)]
        public OneOrMore<decimal?> MaxPrice { get; set; }

        [DataMember(Name = "minPrice", Order = 5)]
        public OneOrMore<decimal?> MinPrice { get; set; }

        [DataMember(Name = "price", Order = 6)]
        public Either<decimal?, string> Price { get; set; }

        [DataMember(Name = "priceCurrency", Order = 7)]
        public OneOrMore<string> PriceCurrency { get; set; }

        [DataMember(Name = "validFrom", Order = 8)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 9)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        [DataMember(Name = "valueAddedTaxIncluded", Order = 10)]
        public OneOrMore<bool?> ValueAddedTaxIncluded { get; set; }
    }
}
