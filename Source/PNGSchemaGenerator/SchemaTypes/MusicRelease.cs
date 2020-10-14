namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    public partial class MusicRelease : MusicPlaylist
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRelease";

        [DataMember(Name = "catalogNumber", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CatalogNumber { get; set; }

        [DataMember(Name = "creditedTo", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> CreditedTo { get; set; }

        [DataMember(Name = "duration", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Enum type MusicReleaseFormatType
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        [DataMember(Name = "recordLabel", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> RecordLabel { get; set; }

        [DataMember(Name = "releaseOf", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicAlbum> ReleaseOf { get; set; }
    }
}
