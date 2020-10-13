namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicComposition : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicComposition";

        [DataMember(Name = "composer", Order = 2)]
        public Either<Organization, Person> Composer { get; set; }

        [DataMember(Name = "firstPerformance", Order = 3)]
        public OneOrMore<Event> FirstPerformance { get; set; }

        [DataMember(Name = "includedComposition", Order = 4)]
        public OneOrMore<MusicComposition> IncludedComposition { get; set; }

        [DataMember(Name = "iswcCode", Order = 5)]
        public OneOrMore<string> IswcCode { get; set; }

        [DataMember(Name = "lyricist", Order = 6)]
        public OneOrMore<Person> Lyricist { get; set; }

        [DataMember(Name = "lyrics", Order = 7)]
        public OneOrMore<CreativeWork> Lyrics { get; set; }

        [DataMember(Name = "musicalKey", Order = 8)]
        public OneOrMore<string> MusicalKey { get; set; }

        [DataMember(Name = "musicArrangement", Order = 9)]
        public OneOrMore<MusicComposition> MusicArrangement { get; set; }

        [DataMember(Name = "musicCompositionForm", Order = 10)]
        public OneOrMore<string> MusicCompositionForm { get; set; }

        [DataMember(Name = "recordedAs", Order = 11)]
        public OneOrMore<MusicRecording> RecordedAs { get; set; }
    }
}
