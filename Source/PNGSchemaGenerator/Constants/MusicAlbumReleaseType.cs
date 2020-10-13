namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicAlbumReleaseType
    {
        [EnumMember(Value = "https://schema.org/AlbumRelease")]
        AlbumRelease,

        [EnumMember(Value = "https://schema.org/BroadcastRelease")]
        BroadcastRelease,

        [EnumMember(Value = "https://schema.org/EPRelease")]
        EPRelease,

        [EnumMember(Value = "https://schema.org/SingleRelease")]
        SingleRelease,
    }
}
