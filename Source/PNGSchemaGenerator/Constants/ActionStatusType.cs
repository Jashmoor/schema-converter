namespace PNGSchemaGenerator
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionStatusType
    {
        [EnumMember(Value = "https://schema.org/ActiveActionStatus")]
        ActiveActionStatus,

        [EnumMember(Value = "https://schema.org/CompletedActionStatus")]
        CompletedActionStatus,

        [EnumMember(Value = "https://schema.org/FailedActionStatus")]
        FailedActionStatus,

        [EnumMember(Value = "https://schema.org/PotentialActionStatus")]
        PotentialActionStatus,
    }
}
