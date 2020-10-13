namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Person : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        [DataMember(Name = "additionalName", Order = 2)]
        public OneOrMore<string> AdditionalName { get; set; }

        [DataMember(Name = "address", Order = 3)]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "affiliation", Order = 4)]
        public OneOrMore<Organization> Affiliation { get; set; }

        [DataMember(Name = "alumniOf", Order = 5)]
        public Either<EducationalOrganization, Organization> AlumniOf { get; set; }

        [DataMember(Name = "award", Order = 6)]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "birthDate", Order = 7)]
        public Either<int?, DateTime?> BirthDate { get; set; }

        [DataMember(Name = "birthPlace", Order = 8)]
        public OneOrMore<Place> BirthPlace { get; set; }

        [DataMember(Name = "brand", Order = 9)]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "callSign", Order = 10)]
        public OneOrMore<string> CallSign { get; set; }

        [DataMember(Name = "children", Order = 11)]
        public OneOrMore<Person> Children { get; set; }

        [DataMember(Name = "colleague", Order = 12)]
        public Either<Person, Uri> Colleague { get; set; }

        [DataMember(Name = "contactPoint", Order = 13)]
        public OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "deathDate", Order = 14)]
        public Either<int?, DateTime?> DeathDate { get; set; }

        [DataMember(Name = "deathPlace", Order = 15)]
        public OneOrMore<Place> DeathPlace { get; set; }

        [DataMember(Name = "duns", Order = 16)]
        public OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 17)]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "familyName", Order = 18)]
        public OneOrMore<string> FamilyName { get; set; }

        [DataMember(Name = "faxNumber", Order = 19)]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "follows", Order = 20)]
        public OneOrMore<Person> Follows { get; set; }

        [DataMember(Name = "funder", Order = 21)]
        public Either<Organization, Person> Funder { get; set; }

        /// <summary>
        /// Uses Enum Type GenderType .... Gender = GenderType.Male / GenderType.Female ...
        /// </summary>
        [DataMember(Name = "gender", Order = 22)]
        public Either<GenderType?, string> Gender { get; set; }

        [DataMember(Name = "givenName", Order = 23)]
        public OneOrMore<string> GivenName { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 24)]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasOccupation", Order = 25)]
        public OneOrMore<Occupation> HasOccupation { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 26)]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 27)]
        public OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "height", Order = 28)]
        public Either<string, QuantitativeValue> Height { get; set; }

        [DataMember(Name = "homeLocation", Order = 29)]
        public Either<ContactPoint, Place> HomeLocation { get; set; }

        [DataMember(Name = "honorificPrefix", Order = 30)]
        public OneOrMore<string> HonorificPrefix { get; set; }

        [DataMember(Name = "honorificSuffix", Order = 31)]
        public OneOrMore<string> HonorificSuffix { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 32)]
        public OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isicV4", Order = 33)]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "jobTitle", Order = 34)]
        public OneOrMore<string> JobTitle { get; set; }

        [DataMember(Name = "knows", Order = 35)]
        public OneOrMore<Person> Knows { get; set; }

        [DataMember(Name = "knowsAbout", Order = 36)]
        public Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 37)]
        public Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "makesOffer", Order = 38)]
        public OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "memberOf", Order = 39)]
        public Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 40)]
        public OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "nationality", Order = 41)]
        public OneOrMore<Country> Nationality { get; set; }

        [DataMember(Name = "netWorth", Order = 42)]
        public Either<MonetaryAmount, PriceSpecification> NetWorth { get; set; }

        [DataMember(Name = "owns", Order = 43)]
        public Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parent", Order = 44)]
        public OneOrMore<Person> Parent { get; set; }

        [DataMember(Name = "performerIn", Order = 45)]
        public OneOrMore<Event> PerformerIn { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 46)]
        public Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "relatedTo", Order = 47)]
        public OneOrMore<Person> RelatedTo { get; set; }

        [DataMember(Name = "seeks", Order = 48)]
        public OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "sibling", Order = 49)]
        public OneOrMore<Person> Sibling { get; set; }

        [DataMember(Name = "sponsor", Order = 50)]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "spouse", Order = 51)]
        public OneOrMore<Person> Spouse { get; set; }

        [DataMember(Name = "taxID", Order = 52)]
        public OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 53)]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "vatID", Order = 54)]
        public OneOrMore<string> VatID { get; set; }

        [DataMember(Name = "weight", Order = 55)]
        public OneOrMore<QuantitativeValue> Weight { get; set; }

        [DataMember(Name = "workLocation", Order = 56)]
        public Either<ContactPoint, Place> WorkLocation { get; set; }

        [DataMember(Name = "worksFor", Order = 57)]
        public OneOrMore<Organization> WorksFor { get; set; }
    }
}
