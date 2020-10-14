namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class LocationFeatureSpecification : PropertyValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocationFeatureSpecification";

        [DataMember(Name = "hoursAvailable", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OpeningHoursSpecification> HoursAvailable { get; set; }

        [DataMember(Name = "validFrom", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
