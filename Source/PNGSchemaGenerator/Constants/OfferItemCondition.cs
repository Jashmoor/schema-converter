namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OfferItemCondition
    {
        [EnumMember(Value = "https://schema.org/DamagedCondition")]
        DamagedCondition,

        [EnumMember(Value = "https://schema.org/NewCondition")]
        NewCondition,

        [EnumMember(Value = "https://schema.org/RefurbishedCondition")]
        RefurbishedCondition,

        [EnumMember(Value = "https://schema.org/UsedCondition")]
        UsedCondition,
    }
}
