namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Organization : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Organization";

        [DataMember(Name = "actionableFeedbackPolicy", Order = 2)]
        public Either<CreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        [DataMember(Name = "address", Order = 3)]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "alumni", Order = 5)]
        public virtual OneOrMore<Person> Alumni { get; set; }

        [DataMember(Name = "areaServed", Order = 6)]
        public Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "award", Order = 7)]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 8)]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "contactPoint", Order = 9)]
        public OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "correctionsPolicy", Order = 10)]
        public Either<CreativeWork, Uri> CorrectionsPolicy { get; set; }

        [DataMember(Name = "department", Order = 11)]
        public OneOrMore<Organization> Department { get; set; }

        [DataMember(Name = "dissolutionDate", Order = 12)]
        public Either<int?, DateTime?> DissolutionDate { get; set; }

        [DataMember(Name = "diversityPolicy", Order = 13)]
        public Either<CreativeWork, Uri> DiversityPolicy { get; set; }

        [DataMember(Name = "diversityStaffingReport", Order = 14)]
        public Either<Article, Uri> DiversityStaffingReport { get; set; }

        [DataMember(Name = "duns", Order = 15)]
        public OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 16)]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "employee", Order = 17)]
        public OneOrMore<Person> Employee { get; set; }

        [DataMember(Name = "ethicsPolicy", Order = 18)]
        public Either<CreativeWork, Uri> EthicsPolicy { get; set; }

        [DataMember(Name = "event", Order = 19)]
        public OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 20)]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "founder", Order = 21)]
        public OneOrMore<Person> Founder { get; set; }

        [DataMember(Name = "foundingDate", Order = 22)]
        public Either<int?, DateTime?> FoundingDate { get; set; }

        [DataMember(Name = "foundingLocation", Order = 23)]
        public OneOrMore<Place> FoundingLocation { get; set; }

        [DataMember(Name = "funder", Order = 24)]
        public Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 25)]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 26)]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 27)]
        public OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 28)]
        public OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isicV4", Order = 29)]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "knowsAbout", Order = 30)]
        public Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 31)]
        public Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "legalName", Order = 32)]
        public OneOrMore<string> LegalName { get; set; }

        [DataMember(Name = "leiCode", Order = 33)]
        public OneOrMore<string> LeiCode { get; set; }

        [DataMember(Name = "location", Order = 34)]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "logo", Order = 35)]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "makesOffer", Order = 36)]
        public OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "member", Order = 37)]
        public Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "memberOf", Order = 38)]
        public Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 39)]
        public OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "numberOfEmployees", Order = 40)]
        public OneOrMore<QuantitativeValue> NumberOfEmployees { get; set; }

        [DataMember(Name = "ownershipFundingInfo", Order = 41)]
        public Either<AboutPage, CreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        [DataMember(Name = "owns", Order = 42)]
        public Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parentOrganization", Order = 43)]
        public OneOrMore<Organization> ParentOrganization { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 44)]
        public Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "review", Order = 45)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "seeks", Order = 46)]
        public OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "slogan", Order = 47)]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "sponsor", Order = 48)]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "subOrganization", Order = 49)]
        public OneOrMore<Organization> SubOrganization { get; set; }

        [DataMember(Name = "taxID", Order = 50)]
        public OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 51)]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "unnamedSourcesPolicy", Order = 52)]
        public Either<CreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        [DataMember(Name = "vatID", Order = 53)]
        public OneOrMore<string> VatID { get; set; }
    }
}
