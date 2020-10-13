namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    public partial class MusicRelease : MusicPlaylist
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRelease";

        [DataMember(Name = "catalogNumber", Order = 2)]
        public OneOrMore<string> CatalogNumber { get; set; }

        [DataMember(Name = "creditedTo", Order = 3)]
        public Either<Organization, Person> CreditedTo { get; set; }

        [DataMember(Name = "duration", Order = 4)]
        public OneOrMore<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Enum type MusicReleaseFormatType
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 5)]
        public OneOrMore<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        [DataMember(Name = "recordLabel", Order = 6)]
        public OneOrMore<Organization> RecordLabel { get; set; }

        [DataMember(Name = "releaseOf", Order = 7)]
        public OneOrMore<MusicAlbum> ReleaseOf { get; set; }
    }
}
