namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class VideoObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoObject";

        [DataMember(Name = "actor", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Actor { get; set; }

        [DataMember(Name = "caption", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "director", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Director { get; set; }

        [DataMember(Name = "musicBy", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MusicGroup, Person> MusicBy { get; set; }

        [DataMember(Name = "thumbnail", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ImageObject> Thumbnail { get; set; }

        [DataMember(Name = "transcript", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Transcript { get; set; }

        [DataMember(Name = "videoFrameSize", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> VideoFrameSize { get; set; }

        [DataMember(Name = "videoQuality", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> VideoQuality { get; set; }
    }
}
