namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class VideoObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoObject";

        [DataMember(Name = "actor", Order = 2)]
        public OneOrMore<Person> Actor { get; set; }

        [DataMember(Name = "caption", Order = 3)]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "director", Order = 4)]
        public OneOrMore<Person> Director { get; set; }

        [DataMember(Name = "musicBy", Order = 5)]
        public Either<MusicGroup, Person> MusicBy { get; set; }

        [DataMember(Name = "thumbnail", Order = 6)]
        public OneOrMore<ImageObject> Thumbnail { get; set; }

        [DataMember(Name = "transcript", Order = 7)]
        public OneOrMore<string> Transcript { get; set; }

        [DataMember(Name = "videoFrameSize", Order = 8)]
        public OneOrMore<string> VideoFrameSize { get; set; }

        [DataMember(Name = "videoQuality", Order = 9)]
        public OneOrMore<string> VideoQuality { get; set; }
    }
}
