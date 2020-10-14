namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PriceSpecification : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PriceSpecification";

        [DataMember(Name = "eligibleQuantity", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> EligibleQuantity { get; set; }

        [DataMember(Name = "eligibleTransactionVolume", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PriceSpecification> EligibleTransactionVolume { get; set; }

        [DataMember(Name = "maxPrice", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<decimal?> MaxPrice { get; set; }

        [DataMember(Name = "minPrice", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<decimal?> MinPrice { get; set; }

        [DataMember(Name = "price", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<decimal?, string> Price { get; set; }

        [DataMember(Name = "priceCurrency", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> PriceCurrency { get; set; }

        [DataMember(Name = "validFrom", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        [DataMember(Name = "valueAddedTaxIncluded", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> ValueAddedTaxIncluded { get; set; }
    }
}
