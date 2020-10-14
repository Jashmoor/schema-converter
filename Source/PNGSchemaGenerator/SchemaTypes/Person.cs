namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
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
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AdditionalName { get; set; }

        [DataMember(Name = "address", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "affiliation", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> Affiliation { get; set; }

        [DataMember(Name = "alumniOf", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<EducationalOrganization, Organization> AlumniOf { get; set; }

        [DataMember(Name = "award", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "birthDate", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> BirthDate { get; set; }

        [DataMember(Name = "birthPlace", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> BirthPlace { get; set; }

        [DataMember(Name = "brand", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Brand, Organization> Brand { get; set; }

        [DataMember(Name = "callSign", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CallSign { get; set; }

        [DataMember(Name = "children", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Children { get; set; }

        [DataMember(Name = "colleague", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Person, Uri> Colleague { get; set; }

        [DataMember(Name = "contactPoint", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPoint> ContactPoint { get; set; }

        [DataMember(Name = "deathDate", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> DeathDate { get; set; }

        [DataMember(Name = "deathPlace", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> DeathPlace { get; set; }

        [DataMember(Name = "duns", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Duns { get; set; }

        [DataMember(Name = "email", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Email { get; set; }

        [DataMember(Name = "familyName", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FamilyName { get; set; }

        [DataMember(Name = "faxNumber", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "follows", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Follows { get; set; }

        [DataMember(Name = "funder", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Funder { get; set; }

        /// <summary>
        /// Uses Enum Type GenderType .... Gender = GenderType.Male / GenderType.Female ...
        /// </summary>
        [DataMember(Name = "gender", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<GenderType?, string> Gender { get; set; }

        [DataMember(Name = "givenName", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> GivenName { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasOccupation", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Occupation> HasOccupation { get; set; }

        [DataMember(Name = "hasOfferCatalog", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OfferCatalog> HasOfferCatalog { get; set; }

        [DataMember(Name = "hasPOS", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> HasPOS { get; set; }

        [DataMember(Name = "height", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, QuantitativeValue> Height { get; set; }

        [DataMember(Name = "homeLocation", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ContactPoint, Place> HomeLocation { get; set; }

        [DataMember(Name = "honorificPrefix", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> HonorificPrefix { get; set; }

        [DataMember(Name = "honorificSuffix", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> HonorificSuffix { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "isicV4", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "jobTitle", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> JobTitle { get; set; }

        [DataMember(Name = "knows", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Knows { get; set; }

        [DataMember(Name = "knowsAbout", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Thing, Uri> KnowsAbout { get; set; }

        [DataMember(Name = "knowsLanguage", Order = 37)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Language, string> KnowsLanguage { get; set; }

        [DataMember(Name = "makesOffer", Order = 38)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Offer> MakesOffer { get; set; }

        [DataMember(Name = "memberOf", Order = 39)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, ProgramMembership> MemberOf { get; set; }

        [DataMember(Name = "naics", Order = 40)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Naics { get; set; }

        [DataMember(Name = "nationality", Order = 41)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Country> Nationality { get; set; }

        [DataMember(Name = "netWorth", Order = 42)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MonetaryAmount, PriceSpecification> NetWorth { get; set; }

        [DataMember(Name = "owns", Order = 43)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<OwnershipInfo, Product> Owns { get; set; }

        [DataMember(Name = "parent", Order = 44)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Parent { get; set; }

        [DataMember(Name = "performerIn", Order = 45)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> PerformerIn { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 46)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "relatedTo", Order = 47)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> RelatedTo { get; set; }

        [DataMember(Name = "seeks", Order = 48)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Demand> Seeks { get; set; }

        [DataMember(Name = "sibling", Order = 49)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Sibling { get; set; }

        [DataMember(Name = "sponsor", Order = 50)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "spouse", Order = 51)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Spouse { get; set; }

        [DataMember(Name = "taxID", Order = 52)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TaxID { get; set; }

        [DataMember(Name = "telephone", Order = 53)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "vatID", Order = 54)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> VatID { get; set; }

        [DataMember(Name = "weight", Order = 55)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> Weight { get; set; }

        [DataMember(Name = "workLocation", Order = 56)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ContactPoint, Place> WorkLocation { get; set; }

        [DataMember(Name = "worksFor", Order = 57)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> WorksFor { get; set; }
    }
}
