namespace PNGSchemaGenerator.Constants
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderType
    {
        [EnumMember(Value = "https://schema.org/Female")]
        Female,

        [EnumMember(Value = "https://schema.org/Male")]
        Male,
    }
}
