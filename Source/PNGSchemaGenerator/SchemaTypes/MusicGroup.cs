namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicGroup : PerformingGroup
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicGroup";

        [DataMember(Name = "album", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MusicAlbum> Album { get; set; }

        [DataMember(Name = "genre", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> Genre { get; set; }
    }
}
