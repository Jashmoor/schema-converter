namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Place : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Place";

        [DataMember(Name = "additionalProperty", Order = 2)]
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "address", Order = 3)]
        public Either<PostalAddress, string> Address { get; set; }

        [DataMember(Name = "aggregateRating", Order = 4)]
        public OneOrMore<AggregateRating> AggregateRating { get; set; }

        [DataMember(Name = "amenityFeature", Order = 5)]
        public virtual OneOrMore<LocationFeatureSpecification> AmenityFeature { get; set; }

        [DataMember(Name = "branchCode", Order = 6)]
        public OneOrMore<string> BranchCode { get; set; }

        [DataMember(Name = "containedInPlace", Order = 7)]
        public OneOrMore<Place> ContainedInPlace { get; set; }

        [DataMember(Name = "containsPlace", Order = 8)]
        public OneOrMore<Place> ContainsPlace { get; set; }

        [DataMember(Name = "event", Order = 9)]
        public OneOrMore<Event> Event { get; set; }

        [DataMember(Name = "faxNumber", Order = 10)]
        public OneOrMore<string> FaxNumber { get; set; }

        [DataMember(Name = "geo", Order = 11)]
        public Either<GeoCoordinates, GeoShape> Geo { get; set; }

        [DataMember(Name = "geoContains", Order = 12)]
        public OneOrMore<Place> GeoContains { get; set; }

        [DataMember(Name = "geoCoveredBy", Order = 13)]
        public OneOrMore<Place> GeoCoveredBy { get; set; }

        [DataMember(Name = "geoCovers", Order = 14)]
        public OneOrMore<Place> GeoCovers { get; set; }

        [DataMember(Name = "geoCrosses", Order = 15)]
        public OneOrMore<Place> GeoCrosses { get; set; }

        [DataMember(Name = "geoDisjoint", Order = 16)]
        public OneOrMore<Place> GeoDisjoint { get; set; }

        [DataMember(Name = "geoEquals", Order = 17)]
        public OneOrMore<Place> GeoEquals { get; set; }

        [DataMember(Name = "geoIntersects", Order = 18)]
        public OneOrMore<Place> GeoIntersects { get; set; }

        [DataMember(Name = "geoOverlaps", Order = 19)]
        public OneOrMore<Place> GeoOverlaps { get; set; }

        [DataMember(Name = "geoTouches", Order = 20)]
        public OneOrMore<Place> GeoTouches { get; set; }

        [DataMember(Name = "geoWithin", Order = 21)]
        public OneOrMore<Place> GeoWithin { get; set; }

        [DataMember(Name = "globalLocationNumber", Order = 22)]
        public OneOrMore<string> GlobalLocationNumber { get; set; }

        [DataMember(Name = "hasDriveThroughService", Order = 23)]
        public OneOrMore<bool?> HasDriveThroughService { get; set; }

        [DataMember(Name = "hasMap", Order = 24)]
        public Either<Map, Uri> HasMap { get; set; }

        [DataMember(Name = "isAccessibleForFree", Order = 25)]
        public OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "isicV4", Order = 26)]
        public OneOrMore<string> IsicV4 { get; set; }

        [DataMember(Name = "latitude", Order = 27)]
        public Either<double?, string> Latitude { get; set; }

        [DataMember(Name = "logo", Order = 28)]
        public Either<ImageObject, Uri> Logo { get; set; }

        [DataMember(Name = "longitude", Order = 29)]
        public Either<double?, string> Longitude { get; set; }

        [DataMember(Name = "maximumAttendeeCapacity", Order = 30)]
        public OneOrMore<int?> MaximumAttendeeCapacity { get; set; }

        [DataMember(Name = "openingHoursSpecification", Order = 31)]
        public OneOrMore<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        [DataMember(Name = "photo", Order = 32)]
        public Either<ImageObject, Photograph> Photo { get; set; }

        [DataMember(Name = "publicAccess", Order = 33)]
        public OneOrMore<bool?> PublicAccess { get; set; }

        [DataMember(Name = "review", Order = 34)]
        public OneOrMore<Review> Review { get; set; }

        [DataMember(Name = "slogan", Order = 35)]
        public OneOrMore<string> Slogan { get; set; }

        [DataMember(Name = "smokingAllowed", Order = 36)]
        public OneOrMore<bool?> SmokingAllowed { get; set; }

        [DataMember(Name = "specialOpeningHoursSpecification", Order = 37)]
        public OneOrMore<OpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        [DataMember(Name = "telephone", Order = 38)]
        public OneOrMore<string> Telephone { get; set; }

        [DataMember(Name = "tourBookingPage", Order = 39)]
        public virtual OneOrMore<Uri> TourBookingPage { get; set; }
    }
}
