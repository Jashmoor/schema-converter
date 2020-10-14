namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicComposition : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicComposition";

        [DataMember(Name = "composer", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Composer { get; set; }

        [DataMember(Name = "firstPerformance", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Event> FirstPerformance { get; set; }

        [DataMember(Name = "includedComposition", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicComposition> IncludedComposition { get; set; }

        [DataMember(Name = "iswcCode", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> IswcCode { get; set; }

        [DataMember(Name = "lyricist", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Person> Lyricist { get; set; }

        [DataMember(Name = "lyrics", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> Lyrics { get; set; }

        [DataMember(Name = "musicalKey", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> MusicalKey { get; set; }

        [DataMember(Name = "musicArrangement", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicComposition> MusicArrangement { get; set; }

        [DataMember(Name = "musicCompositionForm", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> MusicCompositionForm { get; set; }

        [DataMember(Name = "recordedAs", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicRecording> RecordedAs { get; set; }
    }
}
