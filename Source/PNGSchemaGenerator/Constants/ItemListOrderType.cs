namespace PNGSchemaGenerator.Constants
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemListOrderType
    {
        [EnumMember(Value = "https://schema.org/ItemListOrderAscending")]
        ItemListOrderAscending,

        [EnumMember(Value = "https://schema.org/ItemListOrderDescending")]
        ItemListOrderDescending,

        [EnumMember(Value = "https://schema.org/ItemListUnordered")]
        ItemListUnordered,
    }
}
