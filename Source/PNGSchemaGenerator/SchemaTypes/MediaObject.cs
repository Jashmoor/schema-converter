namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MediaObject : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaObject";

        [DataMember(Name = "associatedArticle", Order = 2)]
        public OneOrMore<NewsArticle> AssociatedArticle { get; set; }

        [DataMember(Name = "bitrate", Order = 3)]
        public OneOrMore<string> Bitrate { get; set; }

        [DataMember(Name = "contentSize", Order = 4)]
        public OneOrMore<string> ContentSize { get; set; }

        [DataMember(Name = "contentUrl", Order = 5)]
        public OneOrMore<Uri> ContentUrl { get; set; }

        [DataMember(Name = "duration", Order = 6)]
        public virtual OneOrMore<TimeSpan?> Duration { get; set; }

        [DataMember(Name = "embedUrl", Order = 7)]
        public OneOrMore<Uri> EmbedUrl { get; set; }

        [DataMember(Name = "encodesCreativeWork", Order = 8)]
        public OneOrMore<CreativeWork> EncodesCreativeWork { get; set; }

        [DataMember(Name = "encodingFormat", Order = 9)]
        public override Either<string, Uri> EncodingFormat { get; set; }

        [DataMember(Name = "endTime", Order = 10)]
        public Either<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        [DataMember(Name = "height", Order = 11)]
        public Either<string, QuantitativeValue, int> Height { get; set; }

        [DataMember(Name = "playerType", Order = 12)]
        public OneOrMore<string> PlayerType { get; set; }

        [DataMember(Name = "productionCompany", Order = 13)]
        public OneOrMore<Organization> ProductionCompany { get; set; }

        [DataMember(Name = "regionsAllowed", Order = 14)]
        public OneOrMore<Place> RegionsAllowed { get; set; }

        [DataMember(Name = "requiresSubscription", Order = 15)]
        public Either<bool?, MediaSubscription> RequiresSubscription { get; set; }

        [DataMember(Name = "startTime", Order = 16)]
        public Either<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        [DataMember(Name = "uploadDate", Order = 17)]
        public Either<int?, DateTime?> UploadDate { get; set; }

        [DataMember(Name = "width", Order = 18)]
        public Either<string, QuantitativeValue, int> Width { get; set; }
    }
}
