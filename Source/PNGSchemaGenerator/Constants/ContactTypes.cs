namespace PNGSchemaGenerator
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactType
    {
        [EnumMember(Value = "customer support")]
        CustomerSupport,

        [EnumMember(Value = "technical support")]
        TechnicalSupport,

        [EnumMember(Value = "sales")]
        Sales,

        [EnumMember(Value = "emergency")]
        Emergency
    }
}
