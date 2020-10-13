namespace PNGSchemaGenerator.Constants
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactPointOption
    {
        [EnumMember(Value = "https://schema.org/HearingImpairedSupported")]
        HearingImpairedSupported,

        [EnumMember(Value = "https://schema.org/TollFree")]
        TollFree,
    }
}
