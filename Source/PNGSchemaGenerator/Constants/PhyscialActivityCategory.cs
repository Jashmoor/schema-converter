namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhysicalActivityCategory
    {
        [EnumMember(Value = "https://schema.org/AerobicActivity")]
        AerobicActivity,

        [EnumMember(Value = "https://schema.org/AnaerobicActivity")]
        AnaerobicActivity,

        [EnumMember(Value = "https://schema.org/Balance")]
        Balance,

        [EnumMember(Value = "https://schema.org/Flexibility")]
        Flexibility,

        [EnumMember(Value = "https://schema.org/LeisureTimeActivity")]
        LeisureTimeActivity,

        [EnumMember(Value = "https://schema.org/OccupationalActivity")]
        OccupationalActivity,

        [EnumMember(Value = "https://schema.org/StrengthTraining")]
        StrengthTraining,
    }
}
