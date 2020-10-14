namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Action : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Action";

        [DataMember(Name = "actionStatus", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ActionStatusType?> ActionStatus { get; set; }

        [DataMember(Name = "agent", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Agent { get; set; }

        [DataMember(Name = "endTime", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        [DataMember(Name = "error", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Error { get; set; }

        [DataMember(Name = "instrument", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Instrument { get; set; }

        [DataMember(Name = "location", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "object", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Object { get; set; }

        [DataMember(Name = "participant", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Participant { get; set; }

        [DataMember(Name = "result", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Result { get; set; }

        [DataMember(Name = "startTime", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        [DataMember(Name = "target", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<EntryPoint, Uri> Target { get; set; }
    }
}
