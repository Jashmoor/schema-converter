namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessEntityType
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Business")]
        Business
    }
}
