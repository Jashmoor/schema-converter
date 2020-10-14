namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Place : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Place";

        [DataMember(Name = "additionalProperty", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "address", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "amenityFeature", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<LocationFeatureSpecification> AmenityFeature { get; set; }

        [DataMember(Name = "branchCode", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> BranchCode { get; set; }

        [DataMember(Name = "containedInPlace", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> ContainedInPlace { get; set; }

        [DataMember(Name = "containsPlace", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> ContainsPlace { get; set; }

        [DataMember(Name = "event", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "geo", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<GeoCoordinates, GeoShape> Geo { get; set; }

        [DataMember(Name = "geoContains", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoContains { get; set; }

        [DataMember(Name = "geoCoveredBy", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoCoveredBy { get; set; }

        [DataMember(Name = "geoCovers", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoCovers { get; set; }

        [DataMember(Name = "geoCrosses", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoCrosses { get; set; }

        [DataMember(Name = "geoDisjoint", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoDisjoint { get; set; }

        [DataMember(Name = "geoEquals", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoEquals { get; set; }

        [DataMember(Name = "geoIntersects", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoIntersects { get; set; }

        [DataMember(Name = "geoOverlaps", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoOverlaps { get; set; }

        [DataMember(Name = "geoTouches", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoTouches { get; set; }

        [DataMember(Name = "geoWithin", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> GeoWithin { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasDriveThroughService", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> HasDriveThroughService { get; set; }

        [DataMember(Name = "hasMap", Order = 24)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Map, Uri> HasMap { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 25)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "isicV4", Order = 26)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "latitude", Order = 27)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Latitude { get; set; }

        [DataMember(Name = "logo", Order = 28)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "longitude", Order = 29)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, string> Longitude { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 30)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "openingHoursSpecification", Order = 31)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        [DataMember(Name = "photo", Order = 32)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Photograph> Photo { get; set; }

        [DataMember(Name = "publicAccess", Order = 33)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> PublicAccess { get; set; }

        [DataMember(Name = "review", Order = 34)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "slogan", Order = 35)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "smokingAllowed", Order = 36)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> SmokingAllowed { get; set; }

        [DataMember(Name = "specialOpeningHoursSpecification", Order = 37)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<OpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        [DataMember(Name = "telephone", Order = 38)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "tourBookingPage", Order = 39)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public virtual OneOrMore<Uri> TourBookingPage { get; set; }
    }
}
