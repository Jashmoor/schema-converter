namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryMethod
    {
        [EnumMember(Value = "https://schema.org/OnSitePickup")]
        OnSitePickup,
    }
}
