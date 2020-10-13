namespace PNGSchemaGenerator.Constants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MapCategoryType
    {
        [EnumMember(Value = "https://schema.org/ParkingMap")]
        ParkingMap,

        [EnumMember(Value = "https://schema.org/SeatingMap")]
        SeatingMap,

        [EnumMember(Value = "https://schema.org/TransitMap")]
        TransitMap,

        [EnumMember(Value = "https://schema.org/VenueMap")]
        VenueMap,
    }
}
