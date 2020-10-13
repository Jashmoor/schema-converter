namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventStatusType
    {
        [EnumMember(Value = "https://schema.org/EventCancelled")]
        EventCancelled,

        [EnumMember(Value = "https://schema.org/EventMovedOnline")]
        EventMovedOnline,

        [EnumMember(Value = "https://schema.org/EventPostponed")]
        EventPostponed,

        [EnumMember(Value = "https://schema.org/EventRescheduled")]
        EventRescheduled,

        [EnumMember(Value = "https://schema.org/EventScheduled")]
        EventScheduled,
    }
}
