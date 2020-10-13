namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicReleaseFormatType
    {
        [EnumMember(Value = "https://schema.org/CassetteFormat")]
        CassetteFormat,

        [EnumMember(Value = "https://schema.org/CDFormat")]
        CDFormat,

        [EnumMember(Value = "https://schema.org/DigitalAudioTapeFormat")]
        DigitalAudioTapeFormat,

        [EnumMember(Value = "https://schema.org/DigitalFormat")]
        DigitalFormat,

        [EnumMember(Value = "https://schema.org/DVDFormat")]
        DVDFormat,

        [EnumMember(Value = "https://schema.org/LaserDiscFormat")]
        LaserDiscFormat,

        [EnumMember(Value = "https://schema.org/VinylFormat")]
        VinylFormat,
    }
}
