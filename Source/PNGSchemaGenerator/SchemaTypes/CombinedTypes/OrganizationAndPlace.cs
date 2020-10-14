namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        [DataMember(Name = "actionableFeedbackPolicy", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        [DataMember(Name = "additionalProperty", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "address", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "alumni", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Person> Alumni { get; set; }

        [DataMember(Name = "amenityFeature", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<LocationFeatureSpecification> AmenityFeature { get; set; }

        [DataMember(Name = "areaServed", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "award", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Award { get; set; }

        [DataMember(Name = "branchCode", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> BranchCode { get; set; }

        [DataMember(Name = "brand", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "contactPoint", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "containedInPlace", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> ContainedInPlace { get; set; }

        [DataMember(Name = "containsPlace", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> ContainsPlace { get; set; }

        [DataMember(Name = "correctionsPolicy", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> CorrectionsPolicy { get; set; }

        [DataMember(Name = "department", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Organization> Department { get; set; }

        [DataMember(Name = "dissolutionDate", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<int?, DateTime?> DissolutionDate { get; set; }

        [DataMember(Name = "diversityPolicy", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> DiversityPolicy { get; set; }

        [DataMember(Name = "diversityStaffingReport", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Article, Uri> DiversityStaffingReport { get; set; }

        [DataMember(Name = "duns", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Email { get; set; }

        [DataMember(Name = "employee", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Person> Employee { get; set; }

        [DataMember(Name = "ethicsPolicy", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> EthicsPolicy { get; set; }

        [DataMember(Name = "event", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "founder", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Person> Founder { get; set; }

        [DataMember(Name = "foundingDate", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<int?, DateTime?> FoundingDate { get; set; }

        [DataMember(Name = "foundingLocation", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> FoundingLocation { get; set; }

        [DataMember(Name = "funder", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "geo", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<GeoCoordinates, GeoShape> Geo { get; set; }

        [DataMember(Name = "geoContains", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoContains { get; set; }

        [DataMember(Name = "geoCoveredBy", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoCoveredBy { get; set; }

        [DataMember(Name = "geoCovers", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoCovers { get; set; }

        [DataMember(Name = "geoCrosses", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoCrosses { get; set; }

        [DataMember(Name = "geoDisjoint", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoDisjoint { get; set; }

        [DataMember(Name = "geoEquals", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoEquals { get; set; }

        [DataMember(Name = "geoIntersects", Order = 37)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoIntersects { get; set; }

        [DataMember(Name = "geoOverlaps", Order = 38)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoOverlaps { get; set; }

        [DataMember(Name = "geoTouches", Order = 39)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoTouches { get; set; }

        [DataMember(Name = "geoWithin", Order = 40)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> GeoWithin { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 41)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasDriveThroughService", Order = 42)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<bool?> HasDriveThroughService { get; set; }

        [DataMember(Name = "hasMap", Order = 43)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Map, Uri> HasMap { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 44)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 45)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 46)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 47)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "isicV4", Order = 48)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "knowsAbout", Order = 49)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 50)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "latitude", Order = 51)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<double?, string> Latitude { get; set; }

        [DataMember(Name = "legalName", Order = 52)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> LegalName { get; set; }

        [DataMember(Name = "leiCode", Order = 53)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> LeiCode { get; set; }

        [DataMember(Name = "location", Order = 54)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "logo", Order = 55)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "longitude", Order = 56)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<double?, string> Longitude { get; set; }

        [DataMember(Name = "makesOffer", Order = 57)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 58)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "member", Order = 59)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "memberOf", Order = 60)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 61)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "numberOfEmployees", Order = 62)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<QuantitativeValue> NumberOfEmployees { get; set; }

        [DataMember(Name = "openingHoursSpecification", Order = 63)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        [DataMember(Name = "ownershipFundingInfo", Order = 64)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<AboutPage, CreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        [DataMember(Name = "owns", Order = 65)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parentOrganization", Order = 66)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Organization> ParentOrganization { get; set; }

        [DataMember(Name = "photo", Order = 67)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<ImageObject, Photograph> Photo { get; set; }

        [DataMember(Name = "publicAccess", Order = 68)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<bool?> PublicAccess { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 69)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "review", Order = 70)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "seeks", Order = 71)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "slogan", Order = 71)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "smokingAllowed", Order = 72)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<bool?> SmokingAllowed { get; set; }

        [DataMember(Name = "specialOpeningHoursSpecification", Order = 73)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<OpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        [DataMember(Name = "sponsor", Order = 74)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "subOrganization", Order = 75)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Organization> SubOrganization { get; set; }

        [DataMember(Name = "taxID", Order = 76)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 77)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "tourBookingPage", Order = 78)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Uri> TourBookingPage { get; set; }

        [DataMember(Name = "unnamedSourcesPolicy", Order = 79)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<CreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        [DataMember(Name = "vatID", Order = 80)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<string> VatID { get; set; }
    }

}
