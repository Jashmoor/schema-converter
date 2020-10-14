namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Demand : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Demand";

        /// <summary>
        /// Enum type Payment Method
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PaymentMethod?> AcceptedPaymentMethod { get; set; }

        [DataMember(Name = "advanceBookingRequirement", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> AdvanceBookingRequirement { get; set; }

        [DataMember(Name = "areaServed", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        /// <summary>
        /// Enum type ItemAvailability
        /// </summary>
        [DataMember(Name = "availability", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ItemAvailability?> Availability { get; set; }

        [DataMember(Name = "availabilityEnds", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityEnds { get; set; }

        [DataMember(Name = "availabilityStarts", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityStarts { get; set; }

        [DataMember(Name = "availableAtOrFrom", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> AvailableAtOrFrom { get; set; }

        /// <summary>
        /// Enum type DeliveryMethod
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DeliveryMethod?> AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// Enum type BusinessFunciton
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BusinessFunction?> BusinessFunction { get; set; }

        [DataMember(Name = "deliveryLeadTime", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> DeliveryLeadTime { get; set; }

        /// <summary>
        /// Enum type BusinessEntityType
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BusinessEntityType?> EligibleCustomerType { get; set; }

        [DataMember(Name = "eligibleDuration", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> EligibleDuration { get; set; }

        [DataMember(Name = "eligibleQuantity", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> EligibleQuantity { get; set; }

        [DataMember(Name = "eligibleRegion", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<GeoShape, Place, string> EligibleRegion { get; set; }

        [DataMember(Name = "eligibleTransactionVolume", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PriceSpecification> EligibleTransactionVolume { get; set; }

        [DataMember(Name = "gtin", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin { get; set; }

        [DataMember(Name = "gtin12", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin12 { get; set; }

        [DataMember(Name = "gtin13", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin13 { get; set; }

        [DataMember(Name = "gtin14", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin14 { get; set; }

        [DataMember(Name = "gtin8", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin8 { get; set; }

        [DataMember(Name = "includesObject", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TypeAndQuantityNode> IncludesObject { get; set; }

        [DataMember(Name = "ineligibleRegion", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<GeoShape, Place, string> IneligibleRegion { get; set; }

        [DataMember(Name = "inventoryLevel", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> InventoryLevel { get; set; }

        /// <summary>
        /// Enum type OfferItemCOndition
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OfferItemCondition?> ItemCondition { get; set; }

        [DataMember(Name = "itemOffered", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Event, Product, Service> ItemOffered { get; set; }

        [DataMember(Name = "mpn", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Mpn { get; set; }

        [DataMember(Name = "priceSpecification", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PriceSpecification> PriceSpecification { get; set; }

        [DataMember(Name = "seller", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Seller { get; set; }

        [DataMember(Name = "serialNumber", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> SerialNumber { get; set; }

        [DataMember(Name = "sku", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Sku { get; set; }

        [DataMember(Name = "validFrom", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        [DataMember(Name = "warranty", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<WarrantyPromise> Warranty { get; set; }
    }
}
