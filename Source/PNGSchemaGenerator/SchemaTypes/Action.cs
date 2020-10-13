namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Action : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Action";

        [DataMember(Name = "actionStatus", Order = 2)]
        public OneOrMore<ActionStatusType?> ActionStatus { get; set; }

        [DataMember(Name = "agent", Order = 3)]
        public Either<Organization, Person> Agent { get; set; }

        [DataMember(Name = "endTime", Order = 4)]
        public Either<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        [DataMember(Name = "error", Order = 5)]
        public OneOrMore<Thing> Error { get; set; }

        [DataMember(Name = "instrument", Order = 6)]
        public OneOrMore<Thing> Instrument { get; set; }

        [DataMember(Name = "location", Order = 7)]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "object", Order = 8)]
        public OneOrMore<Thing> Object { get; set; }

        [DataMember(Name = "participant", Order = 9)]
        public Either<Organization, Person> Participant { get; set; }

        [DataMember(Name = "result", Order = 114)]
        public OneOrMore<Thing> Result { get; set; }

        [DataMember(Name = "startTime", Order = 115)]
        public Either<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        [DataMember(Name = "target", Order = 116)]
        public Either<EntryPoint, Uri> Target { get; set; }
    }
}
