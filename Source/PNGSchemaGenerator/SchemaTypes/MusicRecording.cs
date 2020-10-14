namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicRecording : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRecording";

        [DataMember(Name = "byArtist", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MusicGroup, Person> ByArtist { get; set; }

        [DataMember(Name = "duration", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> Duration { get; set; }

        [DataMember(Name = "inAlbum", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicAlbum> InAlbum { get; set; }

        [DataMember(Name = "inPlaylist", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicPlaylist> InPlaylist { get; set; }

        [DataMember(Name = "isrcCode", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> IsrcCode { get; set; }

        [DataMember(Name = "recordingOf", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicComposition> RecordingOf { get; set; }
    }
}
