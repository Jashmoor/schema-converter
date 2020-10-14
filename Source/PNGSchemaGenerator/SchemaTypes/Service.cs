namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Service : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Service";

        [DataMember(Name = "aggregateRating", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "areaServed", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "audience", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "availableChannel", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ServiceChannel> AvailableChannel { get; set; }

        [DataMember(Name = "award", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "broker", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Broker { get; set; }

        /// <summary>
        /// Enum type PhysicalActivityType
        /// </summary>
        [DataMember(Name = "category", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PhysicalActivityCategory?, string, Thing> Category { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hoursAvailable", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OpeningHoursSpecification> HoursAvailable { get; set; }

        [DataMember(Name = "isRelatedTo", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, Service> IsRelatedTo { get; set; }

        [DataMember(Name = "isSimilarTo", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, Service> IsSimilarTo { get; set; }

        [DataMember(Name = "logo", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "offers", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "provider", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Provider { get; set; }

        [DataMember(Name = "providerMobility", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ProviderMobility { get; set; }

        [DataMember(Name = "review", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "serviceOutput", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> ServiceOutput { get; set; }

        [DataMember(Name = "serviceType", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ServiceType { get; set; }

        [DataMember(Name = "slogan", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "termsOfService", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> TermsOfService { get; set; }
    }
}
