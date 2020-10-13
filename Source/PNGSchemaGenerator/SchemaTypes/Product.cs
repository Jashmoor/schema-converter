namespace PNGSchemaGenerator.SchemaTypes
{
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
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "aggregateRating", Order = 3)]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "audience", Order = 4)]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "award", Order = 5)]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 6)]
        public Either<Brand, Organization> Brand { get; set; }

        /// <summary>
        /// Enum type PhysicalActivityType
        /// </summary>
        [DataMember(Name = "category", Order = 7)]
        public Either<PhysicalActivityCategory?, string, Thing> Category { get; set; }

        [DataMember(Name = "color", Order = 8)]
        public OneOrMore<string> Color { get; set; }

        [DataMember(Name = "depth", Order = 9)]
        public Either<string, QuantitativeValue> Depth { get; set; }

        [DataMember(Name = "gtin", Order = 10)]
        public OneOrMore<string> Gtin { get; set; }

        [DataMember(Name = "gtin12", Order = 11)]
        public OneOrMore<string> Gtin12 { get; set; }

        [DataMember(Name = "gtin13", Order = 12)]
        public OneOrMore<string> Gtin13 { get; set; }

        [DataMember(Name = "gtin14", Order = 13)]
        public OneOrMore<string> Gtin14 { get; set; }

        [DataMember(Name = "gtin8", Order = 14)]
        public OneOrMore<string> Gtin8 { get; set; }

        [DataMember(Name = "height", Order = 15)]
        public Either<string, QuantitativeValue> Height { get; set; }

        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 16)]
        public OneOrMore<Product> IsAccessoryOrSparePartFor { get; set; }

        [DataMember(Name = "isConsumableFor", Order = 17)]
        public OneOrMore<Product> IsConsumableFor { get; set; }

        [DataMember(Name = "isRelatedTo", Order = 18)]
        public Either<Product, Service> IsRelatedTo { get; set; }

        [DataMember(Name = "isSimilarTo", Order = 19)]
        public Either<Product, Service> IsSimilarTo { get; set; }

        /// <summary>
        /// Enum type OfferItemCondition
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 20)]
        public OneOrMore<OfferItemCondition?> ItemCondition { get; set; }

        [DataMember(Name = "logo", Order = 21)]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "manufacturer", Order = 22)]
        public OneOrMore<Organization> Manufacturer { get; set; }

        [DataMember(Name = "material", Order = 23)]
        public Either<Product, string, Uri> Material { get; set; }

        [DataMember(Name = "model", Order = 24)]
        public Either<ProductModel, string> Model { get; set; }

        [DataMember(Name = "mpn", Order = 25)]
        public OneOrMore<string> Mpn { get; set; }

        [DataMember(Name = "nsn", Order = 26)]
        public OneOrMore<string> Nsn { get; set; }

        [DataMember(Name = "offers", Order = 27)]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "productID", Order = 28)]
        public OneOrMore<string> ProductID { get; set; }

        [DataMember(Name = "productionDate", Order = 29)]
        public virtual Either<int?, DateTime?> ProductionDate { get; set; }

        [DataMember(Name = "purchaseDate", Order = 30)]
        public virtual Either<int?, DateTime?> PurchaseDate { get; set; }

        [DataMember(Name = "releaseDate", Order = 31)]
        public Either<int?, DateTime?> ReleaseDate { get; set; }

        [DataMember(Name = "review", Order = 32)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "sku", Order = 33)]
        public OneOrMore<string> Sku { get; set; }

        [DataMember(Name = "slogan", Order = 34)]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "weight", Order = 35)]
        public OneOrMore<QuantitativeValue> Weight { get; set; }

        [DataMember(Name = "width", Order = 36)]
        public Either<string, QuantitativeValue> Width { get; set; }
    }
}
