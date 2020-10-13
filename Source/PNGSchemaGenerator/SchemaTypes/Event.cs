namespace PNGSchemaGenerator.SchemaTypes
{
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
        public OneOrMore<Thing> About { get; set; }

        [DataMember(Name = "actor", Order = 3)]
        public OneOrMore<Person> Actor { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "attendee", Order = 5)]
        public Either<Organization, Person> Attendee { get; set; }

        [DataMember(Name = "audience", Order = 6)]
        public OneOrMore<Audience> Audience { get; set; }

        [DataMember(Name = "composer", Order = 7)]
        public Either<Organization, Person> Composer { get; set; }

        [DataMember(Name = "contributor", Order = 8)]
        public Either<Organization, Person> Contributor { get; set; }

        [DataMember(Name = "director", Order = 9)]
        public OneOrMore<Person> Director { get; set; }

        [DataMember(Name = "doorTime", Order = 10)]
        public Either<DateTimeOffset?, TimeSpan?> DoorTime { get; set; }

        [DataMember(Name = "duration", Order = 11)]
        public OneOrMore<TimeSpan?> Duration { get; set; }

        [DataMember(Name = "eventStatus", Order = 12)]
        public OneOrMore<EventStatusType?> EventStatus { get; set; }

        [DataMember(Name = "funder", Order = 13)]
        public Either<Organization, Person> Funder { get; set; }

        [DataMember(Name = "inLanguage", Order = 14)]
        public Either<Language, string> InLanguage { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 15)]
        public virtual OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "location", Order = 16)]
        public Either<Place, PostalAddress, string> Location { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 17)]
        public OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "maximumPhysicalAttendeeCapacity", Order = 18)]
        public OneOrMore<int?> MaximumPhysicalAttendeeCapacity { get; set; }

        [DataMember(Name = "maximumVirtualAttendeeCapacity", Order = 19)]
        public OneOrMore<int?> MaximumVirtualAttendeeCapacity { get; set; }

        [DataMember(Name = "offers", Order = 20)]
        public Either<Demand, Offer> Offers { get; set; }

        [DataMember(Name = "organizer", Order = 21)]
        public Either<Organization, Person> Organizer { get; set; }

        [DataMember(Name = "performer", Order = 22)]
        public Either<Organization, Person> Performer { get; set; }

        [DataMember(Name = "previousStartDate", Order = 23)]
        public Either<int?, DateTime?> PreviousStartDate { get; set; }

        [DataMember(Name = "recordedIn", Order = 24)]
        public OneOrMore<CreativeWork> RecordedIn { get; set; }

        [DataMember(Name = "remainingAttendeeCapacity", Order = 25)]
        public OneOrMore<int?> RemainingAttendeeCapacity { get; set; }

        [DataMember(Name = "review", Order = 26)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "sponsor", Order = 27)]
        public Either<Organization, Person> Sponsor { get; set; }

        [DataMember(Name = "startDate", Order = 28)]
        public Either<int?, DateTime?, DateTimeOffset?> StartDate { get; set; }

        [DataMember(Name = "endDate", Order = 29)]
        public Either<int?, DateTime?, DateTimeOffset?> EndDate { get; set; }

        [DataMember(Name = "subEvent", Order = 30)]
        public OneOrMore<Event> SubEvent { get; set; }

        [DataMember(Name = "superEvent", Order = 31)]
        public OneOrMore<Event> SuperEvent { get; set; }

        [DataMember(Name = "translator", Order = 32)]
        public Either<Organization, Person> Translator { get; set; }

        [DataMember(Name = "typicalAgeRange", Order = 33)]
        public OneOrMore<string> TypicalAgeRange { get; set; }

        [DataMember(Name = "workFeatured", Order = 34)]
        public OneOrMore<CreativeWork> WorkFeatured { get; set; }

        [DataMember(Name = "workPerformed", Order = 35)]
        public OneOrMore<CreativeWork> WorkPerformed { get; set; }
    }
}
