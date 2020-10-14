namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Product : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Product";

        [DataMember(Name = "additionalProperty", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "aggregateRating", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "audience", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "award", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Brand, Organization> Brand { get; set; }

        /// <summary>
        /// Enum type PhysicalActivityType
        /// </summary>
        [DataMember(Name = "category", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PhysicalActivityCategory?, string, Thing> Category { get; set; }

        [DataMember(Name = "color", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Color { get; set; }

        [DataMember(Name = "depth", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, QuantitativeValue> Depth { get; set; }

        [DataMember(Name = "gtin", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin { get; set; }

        [DataMember(Name = "gtin12", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin12 { get; set; }

        [DataMember(Name = "gtin13", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin13 { get; set; }

        [DataMember(Name = "gtin14", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin14 { get; set; }

        [DataMember(Name = "gtin8", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Gtin8 { get; set; }

        [DataMember(Name = "height", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, QuantitativeValue> Height { get; set; }

        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Product> IsAccessoryOrSparePartFor { get; set; }

        [DataMember(Name = "isConsumableFor", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Product> IsConsumableFor { get; set; }

        [DataMember(Name = "isRelatedTo", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, Service> IsRelatedTo { get; set; }

        [DataMember(Name = "isSimilarTo", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, Service> IsSimilarTo { get; set; }

        /// <summary>
        /// Enum type OfferItemCondition
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OfferItemCondition?> ItemCondition { get; set; }

        [DataMember(Name = "logo", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "manufacturer", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> Manufacturer { get; set; }

        [DataMember(Name = "material", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, string, Uri> Material { get; set; }

        [DataMember(Name = "model", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ProductModel, string> Model { get; set; }

        [DataMember(Name = "mpn", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Mpn { get; set; }

        [DataMember(Name = "nsn", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Nsn { get; set; }

        [DataMember(Name = "offers", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "productID", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ProductID { get; set; }

        [DataMember(Name = "productionDate", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<int?, DateTime?> ProductionDate { get; set; }

        [DataMember(Name = "purchaseDate", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<int?, DateTime?> PurchaseDate { get; set; }

        [DataMember(Name = "releaseDate", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> ReleaseDate { get; set; }

        [DataMember(Name = "review", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "sku", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Sku { get; set; }

        [DataMember(Name = "slogan", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "weight", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> Weight { get; set; }

        [DataMember(Name = "width", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, QuantitativeValue> Width { get; set; }
    }
}
