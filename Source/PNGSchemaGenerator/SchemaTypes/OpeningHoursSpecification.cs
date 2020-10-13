namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class OpeningHoursSpecification : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        [DataMember(Name = "closes", Order = 2)]
        public OneOrMore<TimeSpan?> Closes { get; set; }

        [DataMember(Name = "dayOfWeek", Order = 3)]
        public OneOrMore<DayOfWeek?> DayOfWeek { get; set; }

        [DataMember(Name = "opens", Order = 4)]
        public OneOrMore<TimeSpan?> Opens { get; set; }

        [DataMember(Name = "validFrom", Order = 5)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 6)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
