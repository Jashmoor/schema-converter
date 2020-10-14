namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class CreativeWork : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWork";

        [DataMember(Name = "about", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> About { get; set; }

        [DataMember(Name = "abstract", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Abstract { get; set; }

        [DataMember(Name = "accessibilityAPI", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessibilityAPI { get; set; }

        [DataMember(Name = "accessibilityControl", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessibilityControl { get; set; }

        [DataMember(Name = "accessibilityFeature", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessibilityFeature { get; set; }

        [DataMember(Name = "accessibilityHazard", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessibilityHazard { get; set; }

        [DataMember(Name = "accessibilitySummary", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessibilitySummary { get; set; }

        [DataMember(Name = "accessMode", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AccessMode { get; set; }

        [DataMember(Name = "accessModeSufficient", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ItemList> AccessModeSufficient { get; set; }

        [DataMember(Name = "accountablePerson", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> AccountablePerson { get; set; }

        [DataMember(Name = "acquireLicensePage", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> AcquireLicensePage { get; set; }

        [DataMember(Name = "aggregateRating", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "alternativeHeadline", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AlternativeHeadline { get; set; }

        [DataMember(Name = "associatedMedia", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MediaObject> AssociatedMedia { get; set; }

        [DataMember(Name = "audience", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "audio", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<AudioObject, Clip, MusicRecording> Audio { get; set; }

        [DataMember(Name = "author", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Author { get; set; }

        [DataMember(Name = "award", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Award { get; set; }

        [DataMember(Name = "character", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Character { get; set; }

        [DataMember(Name = "citation", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, string> Citation { get; set; }

        [DataMember(Name = "comment", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Comment> Comment { get; set; }

        [DataMember(Name = "commentCount", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> CommentCount { get; set; }

        [DataMember(Name = "conditionsOfAccess", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ConditionsOfAccess { get; set; }

        [DataMember(Name = "contentLocation", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> ContentLocation { get; set; }

        [DataMember(Name = "contentRating", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Rating, string> ContentRating { get; set; }

        [DataMember(Name = "contentReferenceTime", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DateTimeOffset?> ContentReferenceTime { get; set; }

        [DataMember(Name = "contributor", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Contributor { get; set; }

        [DataMember(Name = "copyrightHolder", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> CopyrightHolder { get; set; }

        [DataMember(Name = "copyrightYear", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> CopyrightYear { get; set; }

        [DataMember(Name = "correction", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> Correction { get; set; }

        [DataMember(Name = "creativeWorkStatus", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CreativeWorkStatus { get; set; }

        [DataMember(Name = "creator", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Creator { get; set; }

        [DataMember(Name = "dateCreated", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        [DataMember(Name = "dateModified", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        [DataMember(Name = "datePublished", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DatePublished { get; set; }

        [DataMember(Name = "discussionUrl", Order = 37)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> DiscussionUrl { get; set; }

        [DataMember(Name = "editEIDR", Order = 38)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> EditEIDR { get; set; }

        [DataMember(Name = "editor", Order = 39)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Editor { get; set; }

        [DataMember(Name = "educationalAlignment", Order = 40)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AlignmentObject> EducationalAlignment { get; set; }

        [DataMember(Name = "educationalUse", Order = 41)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> EducationalUse { get; set; }

        [DataMember(Name = "encoding", Order = 42)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MediaObject> Encoding { get; set; }

        [DataMember(Name = "encodingFormat", Order = 43)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual Either<string, Uri> EncodingFormat { get; set; }

        [DataMember(Name = "exampleOfWork", Order = 44)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> ExampleOfWork { get; set; }

        [DataMember(Name = "expires", Order = 45)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> Expires { get; set; }

        [DataMember(Name = "funder", Order = 46)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "genre", Order = 47)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> Genre { get; set; }

        [DataMember(Name = "hasPart", Order = 48)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> HasPart { get; set; }

        [DataMember(Name = "headline", Order = 49)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Headline { get; set; }

        [DataMember(Name = "inLanguage", Order = 50)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Language, string> InLanguage { get; set; }

        [DataMember(Name = "interactionStatistic", Order = 51)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<InteractionCounter> InteractionStatistic { get; set; }

        [DataMember(Name = "interactivityType", Order = 52)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> InteractivityType { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 53)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "isBasedOn", Order = 54)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Product, Uri> IsBasedOn { get; set; }

        [DataMember(Name = "isFamilyFriendly", Order = 55)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> IsFamilyFriendly { get; set; }

        [DataMember(Name = "isPartOf", Order = 56)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> IsPartOf { get; set; }

        [DataMember(Name = "keywords", Order = 57)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Keywords { get; set; }

        [DataMember(Name = "learningResourceType", Order = 58)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> LearningResourceType { get; set; }

        [DataMember(Name = "license", Order = 59)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> License { get; set; }

        [DataMember(Name = "locationCreated", Order = 60)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> LocationCreated { get; set; }

        [DataMember(Name = "mainEntity", Order = 61)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> MainEntity { get; set; }

        [DataMember(Name = "maintainer", Order = 62)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Maintainer { get; set; }

        [DataMember(Name = "material", Order = 63)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, string, Uri> Material { get; set; }

        [DataMember(Name = "materialExtent", Order = 64)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<QuantitativeValue, string> MaterialExtent { get; set; }

        [DataMember(Name = "mentions", Order = 65)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Mentions { get; set; }

        [DataMember(Name = "offers", Order = 66)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "position", Order = 67)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, string> Position { get; set; }

        [DataMember(Name = "producer", Order = 68)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Producer { get; set; }

        [DataMember(Name = "provider", Order = 69)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Provider { get; set; }

        [DataMember(Name = "publication", Order = 70)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PublicationEvent> Publication { get; set; }

        [DataMember(Name = "publisher", Order = 71)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Publisher { get; set; }

        [DataMember(Name = "publisherImprint", Order = 72)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> PublisherImprint { get; set; }

        [DataMember(Name = "publishingPrinciples", Order = 73)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> PublishingPrinciples { get; set; }

        [DataMember(Name = "recordedAt", Order = 74)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> RecordedAt { get; set; }

        [DataMember(Name = "releasedEvent", Order = 75)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PublicationEvent> ReleasedEvent { get; set; }

        [DataMember(Name = "review", Order = 76)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "schemaVersion", Order = 77)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> SchemaVersion { get; set; }

        [DataMember(Name = "sdDatePublished", Order = 78)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> SdDatePublished { get; set; }

        [DataMember(Name = "sdLicense", Order = 79)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> SdLicense { get; set; }

        [DataMember(Name = "sdPublisher", Order = 80)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> SdPublisher { get; set; }

        [DataMember(Name = "sourceOrganization", Order = 81)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> SourceOrganization { get; set; }

        [DataMember(Name = "spatial", Order = 82)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> Spatial { get; set; }

        [DataMember(Name = "spatialCoverage", Order = 83)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> SpatialCoverage { get; set; }

        [DataMember(Name = "sponsor", Order = 84)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "temporal", Order = 85)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTimeOffset?, string> Temporal { get; set; }

        [DataMember(Name = "temporalCoverage", Order = 86)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTimeOffset?, string, Uri> TemporalCoverage { get; set; }

        [DataMember(Name = "text", Order = 87)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Text { get; set; }

        [DataMember(Name = "thumbnailUrl", Order = 88)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> ThumbnailUrl { get; set; }

        [DataMember(Name = "timeRequired", Order = 89)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> TimeRequired { get; set; }

        [DataMember(Name = "translationOfWork", Order = 90)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> TranslationOfWork { get; set; }

        [DataMember(Name = "translator", Order = 91)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Translator { get; set; }

        [DataMember(Name = "typicalAgeRange", Order = 92)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TypicalAgeRange { get; set; }

        [DataMember(Name = "usageInfo", Order = 93)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> UsageInfo { get; set; }

        [DataMember(Name = "version", Order = 94)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Version { get; set; }

        [DataMember(Name = "video", Order = 95)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Clip, VideoObject> Video { get; set; }

        [DataMember(Name = "workExample", Order = 96)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> WorkExample { get; set; }

        [DataMember(Name = "workTranslation", Order = 97)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> WorkTranslation { get; set; }
    }
}
