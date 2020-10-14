namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicAlbum : MusicPlaylist
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicAlbum";

        /// <summary>
        /// Enum type MusicAlbumProductionType
        /// </summary>
        [DataMember(Name = "albumProductionType", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicAlbumProductionType?> AlbumProductionType { get; set; }

        [DataMember(Name = "albumRelease", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicRelease> AlbumRelease { get; set; }

        [DataMember(Name = "albumReleaseType", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicAlbumReleaseType?> AlbumReleaseType { get; set; }

        [DataMember(Name = "byArtist", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MusicGroup, Person> ByArtist { get; set; }
    }
}
