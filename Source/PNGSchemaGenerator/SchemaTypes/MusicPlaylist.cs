namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicPlaylist : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicPlaylist";

        [DataMember(Name = "numTracks", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> NumTracks { get; set; }

        [DataMember(Name = "track", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ItemList, MusicRecording> Track { get; set; }
    }
}
