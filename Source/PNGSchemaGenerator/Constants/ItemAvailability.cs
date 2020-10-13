namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemAvailability
    {
        [EnumMember(Value = "https://schema.org/Discontinued")]
        Discontinued,

        [EnumMember(Value = "https://schema.org/InStock")]
        InStock,

        [EnumMember(Value = "https://schema.org/InStoreOnly")]
        InStoreOnly,

        [EnumMember(Value = "https://schema.org/LimitedAvailability")]
        LimitedAvailability,

        [EnumMember(Value = "https://schema.org/OnlineOnly")]
        OnlineOnly,

        [EnumMember(Value = "https://schema.org/OutOfStock")]
        OutOfStock,

        [EnumMember(Value = "https://schema.org/PreOrder")]
        PreOrder,

        [EnumMember(Value = "https://schema.org/PreSale")]
        PreSale,

        [EnumMember(Value = "https://schema.org/SoldOut")]
        SoldOut,
    }
}
