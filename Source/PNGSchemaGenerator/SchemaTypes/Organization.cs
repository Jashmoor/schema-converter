namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Organization : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Organization";

        [DataMember(Name = "actionableFeedbackPolicy", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        [DataMember(Name = "address", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "alumni", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Person> Alumni { get; set; }

        [DataMember(Name = "areaServed", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<AdministrativeArea, GeoShape, Place, string> AreaServed { get; set; }

        [DataMember(Name = "award", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "brand", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "contactPoint", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "correctionsPolicy", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> CorrectionsPolicy { get; set; }

        [DataMember(Name = "department", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> Department { get; set; }

        [DataMember(Name = "dissolutionDate", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> DissolutionDate { get; set; }

        [DataMember(Name = "diversityPolicy", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> DiversityPolicy { get; set; }

        [DataMember(Name = "diversityStaffingReport", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Article, Uri> DiversityStaffingReport { get; set; }

        [DataMember(Name = "duns", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "employee", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Employee { get; set; }

        [DataMember(Name = "ethicsPolicy", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> EthicsPolicy { get; set; }

        [DataMember(Name = "event", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "founder", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Founder { get; set; }

        [DataMember(Name = "foundingDate", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> FoundingDate { get; set; }

        [DataMember(Name = "foundingLocation", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> FoundingLocation { get; set; }

        [DataMember(Name = "funder", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isicV4", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "knowsAbout", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "legalName", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> LegalName { get; set; }

        [DataMember(Name = "leiCode", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> LeiCode { get; set; }

        [DataMember(Name = "location", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "logo", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "makesOffer", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "member", Order = 37)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "memberOf", Order = 38)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 39)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "numberOfEmployees", Order = 40)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> NumberOfEmployees { get; set; }

        [DataMember(Name = "ownershipFundingInfo", Order = 41)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<AboutPage, CreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        [DataMember(Name = "owns", Order = 42)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parentOrganization", Order = 43)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> ParentOrganization { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 44)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "review", Order = 45)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "seeks", Order = 46)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "slogan", Order = 47)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "sponsor", Order = 48)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "subOrganization", Order = 49)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> SubOrganization { get; set; }

        [DataMember(Name = "taxID", Order = 50)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 51)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "unnamedSourcesPolicy", Order = 52)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        [DataMember(Name = "vatID", Order = 53)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> VatID { get; set; }
    }
}
