namespace PNGSchemaGenerator.Constants
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessFunction
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ProvideService")]
        ProvideService,
    }
}
