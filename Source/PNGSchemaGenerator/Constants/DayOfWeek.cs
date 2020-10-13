namespace PNGSchemaGenerator
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeek
    {
        [EnumMember(Value = "https://schema.org/Sunday")]
        Sunday,

        [EnumMember(Value = "https://schema.org/Monday")]
        Monday,

        [EnumMember(Value = "https://schema.org/Tuesday")]
        Tuesday,

        [EnumMember(Value = "https://schema.org/Wednesday")]
        Wednesday,

        [EnumMember(Value = "https://schema.org/Thursday")]
        Thursday,

        [EnumMember(Value = "https://schema.org/Friday")]
        Friday,

        [EnumMember(Value = "https://schema.org/Saturday")]
        Saturday,

        [EnumMember(Value = "https://schema.org/PublicHolidays")]
        PublicHolidays,
    }
}
