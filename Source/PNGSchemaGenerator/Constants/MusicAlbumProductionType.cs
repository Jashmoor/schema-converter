namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicAlbumProductionType
    {
        [EnumMember(Value = "https://schema.org/CompilationAlbum")]
        CompilationAlbum,

        [EnumMember(Value = "https://schema.org/DemoAlbum")]
        DemoAlbum,

        [EnumMember(Value = "https://schema.org/DJMixAlbum")]
        DJMixAlbum,

        [EnumMember(Value = "https://schema.org/LiveAlbum")]
        LiveAlbum,

        [EnumMember(Value = "https://schema.org/MixtapeAlbum")]
        MixtapeAlbum,

        [EnumMember(Value = "https://schema.org/RemixAlbum")]
        RemixAlbum,

        [EnumMember(Value = "https://schema.org/SoundtrackAlbum")]
        SoundtrackAlbum,

        [EnumMember(Value = "https://schema.org/SpokenWordAlbum")]
        SpokenWordAlbum,

        [EnumMember(Value = "https://schema.org/StudioAlbum")]
        StudioAlbum,
    }
}
