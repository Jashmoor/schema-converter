namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SpecialAnnouncement : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpecialAnnouncement";

        [DataMember(Name = "announcementLocation", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<LocalBusiness, CivicStructure> AnnouncementLocation { get; set; }

        /// <summary>
        /// Enum type PhysicalActivityCategory
        /// </summary>
        [DataMember(Name = "category", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PhysicalActivityCategory?, string, Thing, Uri> Category { get; set; }

        [DataMember(Name = "datePosted", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTime?, DateTimeOffset?, string> DatePosted { get; set; }

        [DataMember(Name = "diseasePreventionInfo", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> DiseasePreventionInfo { get; set; }

        [DataMember(Name = "diseaseSpreadStatistics", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Dataset, Uri, WebContent> DiseaseSpreadStatistics { get; set; }

        [DataMember(Name = "gettingTestedInfo", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> GettingTestedInfo { get; set; }

        [DataMember(Name = "governementBenefitsInfo", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<GovernmentService> GovernmentBenefitsInfo { get; set; }

        [DataMember(Name = "newsUpdatesAndGuidelines", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> NewsUpdatesAndGuidelines { get; set; }

        [DataMember(Name = "publicTransportClosuresInfo", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> PublicTransportClosuresInfo { get; set; }

        [DataMember(Name = "quarantineGuidelines", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> QuarantineGuidelines { get; set; }

        [DataMember(Name = "schoolClosuresInfo", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> SchoolClosuresInfo { get; set; }

        [DataMember(Name = "travelBans", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Uri, WebContent> TravelBans { get; set; }

        [DataMember(Name = "webFeed", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DataFeed, Uri> WebFeed { get; set; }
    }
}
