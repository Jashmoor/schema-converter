namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class OpeningHoursSpecification : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        [DataMember(Name = "closes", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> Closes { get; set; }

        [DataMember(Name = "dayOfWeek", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DayOfWeek?> DayOfWeek { get; set; }

        [DataMember(Name = "opens", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> Opens { get; set; }

        [DataMember(Name = "validFrom", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
