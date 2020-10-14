namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Event : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Event";

        [DataMember(Name = "about", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> About { get; set; }

        [DataMember(Name = "actor", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Actor { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "attendee", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Attendee { get; set; }

        [DataMember(Name = "audience", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "composer", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Composer { get; set; }

        [DataMember(Name = "contributor", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Contributor { get; set; }

        [DataMember(Name = "director", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Director { get; set; }

        [DataMember(Name = "doorTime", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<DateTimeOffset?, TimeSpan?> DoorTime { get; set; }

        [DataMember(Name = "duration", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> Duration { get; set; }

        [DataMember(Name = "eventStatus", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<EventStatusType?> EventStatus { get; set; }

        [DataMember(Name = "funder", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "inLanguage", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Language, string> InLanguage { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "location", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "maximumPhysicalAttendeeCapacity", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> MaximumPhysicalAttendeeCapacity { get; set; }

        [DataMember(Name = "maximumVirtualAttendeeCapacity", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> MaximumVirtualAttendeeCapacity { get; set; }

        [DataMember(Name = "offers", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "organizer", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Organizer { get; set; }

        [DataMember(Name = "performer", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Performer { get; set; }

        [DataMember(Name = "previousStartDate", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> PreviousStartDate { get; set; }

        [DataMember(Name = "recordedIn", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> RecordedIn { get; set; }

        [DataMember(Name = "remainingAttendeeCapacity", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> RemainingAttendeeCapacity { get; set; }

        [DataMember(Name = "review", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "sponsor", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "startDate", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> StartDate { get; set; }

        [DataMember(Name = "endDate", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> EndDate { get; set; }

        [DataMember(Name = "subEvent", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> SubEvent { get; set; }

        [DataMember(Name = "superEvent", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> SuperEvent { get; set; }

        [DataMember(Name = "translator", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Translator { get; set; }

        [DataMember(Name = "typicalAgeRange", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TypicalAgeRange { get; set; }

        [DataMember(Name = "workFeatured", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> WorkFeatured { get; set; }

        [DataMember(Name = "workPerformed", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> WorkPerformed { get; set; }
    }
}
