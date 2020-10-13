namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarrantyScope
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Labor-BringIn")]
        BringIn,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PartsAndLabor-PickUp")]
        Pickup
    }
}
