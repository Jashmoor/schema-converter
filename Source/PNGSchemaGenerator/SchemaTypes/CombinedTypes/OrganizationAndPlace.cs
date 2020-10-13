namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        [DataMember(Name = "actionableFeedbackPolicy", Order = 2)]
        public virtual Either<CreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        [DataMember(Name = "additionalProperty", Order = 3)]
        public virtual OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "address", Order = 4)]
        public virtual Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 5)]
        public virtual OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "alumni", Order = 6)]
        public virtual OneOrMore<Person> Alumni { get; set; }

        [DataMember(Name = "amenityFeature", Order = 7)]
        public virtual OneOrMore<LocationFeatureSpecification> AmenityFeature { get; set; }

        [DataMember(Name = "areaServed", Order = 8)]
        public virtual Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "award", Order = 9)]
        public virtual OneOrMore<string> Award { get; set; }

        [DataMember(Name = "branchCode", Order = 10)]
        public virtual OneOrMore<string> BranchCode { get; set; }

        [DataMember(Name = "brand", Order = 11)]
        public virtual Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "contactPoint", Order = 12)]
        public virtual OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "containedInPlace", Order = 13)]
        public virtual OneOrMore<Place> ContainedInPlace { get; set; }

        [DataMember(Name = "containsPlace", Order = 14)]
        public virtual OneOrMore<Place> ContainsPlace { get; set; }

        [DataMember(Name = "correctionsPolicy", Order = 15)]
        public virtual Either<CreativeWork, Uri> CorrectionsPolicy { get; set; }

        [DataMember(Name = "department", Order = 16)]
        public virtual OneOrMore<Organization> Department { get; set; }

        [DataMember(Name = "dissolutionDate", Order = 17)]
        public virtual Either<int?, DateTime?> DissolutionDate { get; set; }

        [DataMember(Name = "diversityPolicy", Order = 18)]
        public virtual Either<CreativeWork, Uri> DiversityPolicy { get; set; }

        [DataMember(Name = "diversityStaffingReport", Order = 19)]
        public virtual Either<Article, Uri> DiversityStaffingReport { get; set; }

        [DataMember(Name = "duns", Order = 20)]
        public virtual OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 21)]
        public virtual OneOrMore<string> Email { get; set; }

        [DataMember(Name = "employee", Order = 22)]
        public virtual OneOrMore<Person> Employee { get; set; }

        [DataMember(Name = "ethicsPolicy", Order = 23)]
        public virtual Either<CreativeWork, Uri> EthicsPolicy { get; set; }

        [DataMember(Name = "event", Order = 24)]
        public virtual OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 25)]
        public virtual OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "founder", Order = 26)]
        public virtual OneOrMore<Person> Founder { get; set; }

        [DataMember(Name = "foundingDate", Order = 27)]
        public virtual Either<int?, DateTime?> FoundingDate { get; set; }

        [DataMember(Name = "foundingLocation", Order = 28)]
        public virtual OneOrMore<Place> FoundingLocation { get; set; }

        [DataMember(Name = "funder", Order = 29)]
        public virtual Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "geo", Order = 30)]
        public virtual Either<GeoCoordinates, GeoShape> Geo { get; set; }

        [DataMember(Name = "geoContains", Order = 31)]
        public virtual OneOrMore<Place> GeoContains { get; set; }

        [DataMember(Name = "geoCoveredBy", Order = 32)]
        public virtual OneOrMore<Place> GeoCoveredBy { get; set; }

        [DataMember(Name = "geoCovers", Order = 33)]
        public virtual OneOrMore<Place> GeoCovers { get; set; }

        [DataMember(Name = "geoCrosses", Order = 34)]
        public virtual OneOrMore<Place> GeoCrosses { get; set; }

        [DataMember(Name = "geoDisjoint", Order = 35)]
        public virtual OneOrMore<Place> GeoDisjoint { get; set; }

        [DataMember(Name = "geoEquals", Order = 36)]
        public virtual OneOrMore<Place> GeoEquals { get; set; }

        [DataMember(Name = "geoIntersects", Order = 37)]
        public virtual OneOrMore<Place> GeoIntersects { get; set; }

        [DataMember(Name = "geoOverlaps", Order = 38)]
        public virtual OneOrMore<Place> GeoOverlaps { get; set; }

        [DataMember(Name = "geoTouches", Order = 39)]
        public virtual OneOrMore<Place> GeoTouches { get; set; }

        [DataMember(Name = "geoWithin", Order = 40)]
        public virtual OneOrMore<Place> GeoWithin { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 41)]
        public virtual OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasDriveThroughService", Order = 42)]
        public virtual OneOrMore<bool?> HasDriveThroughService { get; set; }

        [DataMember(Name = "hasMap", Order = 43)]
        public virtual Either<Map, Uri> HasMap { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 44)]
        public virtual OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 45)]
        public virtual OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 46)]
        public virtual OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 47)]
        public virtual OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "isicV4", Order = 48)]
        public virtual OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "knowsAbout", Order = 49)]
        public virtual Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 50)]
        public virtual Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "latitude", Order = 51)]
        public virtual Either<double?, string> Latitude { get; set; }

        [DataMember(Name = "legalName", Order = 52)]
        public virtual OneOrMore<string> LegalName { get; set; }

        [DataMember(Name = "leiCode", Order = 53)]
        public virtual OneOrMore<string> LeiCode { get; set; }

        [DataMember(Name = "location", Order = 54)]
        public virtual Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "logo", Order = 55)]
        public virtual Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "longitude", Order = 56)]
        public virtual Either<double?, string> Longitude { get; set; }

        [DataMember(Name = "makesOffer", Order = 57)]
        public virtual OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 58)]
        public virtual OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "member", Order = 59)]
        public virtual Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "memberOf", Order = 60)]
        public virtual Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 61)]
        public virtual OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "numberOfEmployees", Order = 62)]
        public virtual OneOrMore<QuantitativeValue> NumberOfEmployees { get; set; }

        [DataMember(Name = "openingHoursSpecification", Order = 63)]
        public virtual OneOrMore<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        [DataMember(Name = "ownershipFundingInfo", Order = 64)]
        public virtual Either<AboutPage, CreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        [DataMember(Name = "owns", Order = 65)]
        public virtual Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parentOrganization", Order = 66)]
        public virtual OneOrMore<Organization> ParentOrganization { get; set; }

        [DataMember(Name = "photo", Order = 67)]
        public virtual Either<ImageObject, Photograph> Photo { get; set; }

        [DataMember(Name = "publicAccess", Order = 68)]
        public virtual OneOrMore<bool?> PublicAccess { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 69)]
        public virtual Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "review", Order = 70)]
        public virtual OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "seeks", Order = 71)]
        public virtual OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "slogan", Order = 71)]
        public virtual OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "smokingAllowed", Order = 72)]
        public virtual OneOrMore<bool?> SmokingAllowed { get; set; }

        [DataMember(Name = "specialOpeningHoursSpecification", Order = 73)]
        public virtual OneOrMore<OpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        [DataMember(Name = "sponsor", Order = 74)]
        public virtual Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "subOrganization", Order = 75)]
        public virtual OneOrMore<Organization> SubOrganization { get; set; }

        [DataMember(Name = "taxID", Order = 76)]
        public virtual OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 77)]
        public virtual OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "tourBookingPage", Order = 78)]
        public virtual OneOrMore<Uri> TourBookingPage { get; set; }

        [DataMember(Name = "unnamedSourcesPolicy", Order = 79)]
        public virtual Either<CreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        [DataMember(Name = "vatID", Order = 80)]
        public virtual OneOrMore<string> VatID { get; set; }
    }

}
