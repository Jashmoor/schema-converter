namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicPlaylist : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicPlaylist";

        [DataMember(Name = "numTracks", Order = 2)]
        public OneOrMore<int?> NumTracks { get; set; }

        [DataMember(Name = "track", Order = 3)]
        public Either<ItemList, MusicRecording> Track { get; set; }
    }
}
