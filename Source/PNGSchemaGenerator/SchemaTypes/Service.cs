namespace PNGSchemaGenerator.SchemaTypes
{
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
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "areaServed", Order = 3)]
        public Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "audience", Order = 4)]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "availableChannel", Order = 5)]
        public OneOrMore<ServiceChannel> AvailableChannel { get; set; }

        [DataMember(Name = "award", Order = 6)]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 7)]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "broker", Order = 8)]
        public Either<Organization, Person> Broker { get; set; }

        /// <summary>
        /// Enum type PhysicalActivityType
        /// </summary>
        [DataMember(Name = "category", Order = 9)]
        public Either<PhysicalActivityCategory?, string, Thing> Category { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 10)]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hoursAvailable", Order = 11)]
        public OneOrMore<OpeningHoursSpecification> HoursAvailable { get; set; }

        [DataMember(Name = "isRelatedTo", Order = 12)]
        public Either<Product, Service> IsRelatedTo { get; set; }

        [DataMember(Name = "isSimilarTo", Order = 13)]
        public Either<Product, Service> IsSimilarTo { get; set; }

        [DataMember(Name = "logo", Order = 14)]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "offers", Order = 15)]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "provider", Order = 16)]
        public Either<Organization, Person> Provider { get; set; }

        [DataMember(Name = "providerMobility", Order = 17)]
        public OneOrMore<string> ProviderMobility { get; set; }

        [DataMember(Name = "review", Order = 18)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "serviceOutput", Order = 19)]
        public OneOrMore<Thing> ServiceOutput { get; set; }

        [DataMember(Name = "serviceType", Order = 20)]
        public OneOrMore<string> ServiceType { get; set; }

        [DataMember(Name = "slogan", Order = 21)]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "termsOfService", Order = 22)]
        public Either<string, Uri> TermsOfService { get; set; }
    }
}
