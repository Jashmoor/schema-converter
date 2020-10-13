namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MusicGroup : PerformingGroup
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicGroup";

        [DataMember(Name = "album", Order = 306)]
        public OneOrMore<MusicAlbum> Album { get; set; }

        [DataMember(Name = "genre", Order = 307)]
        public Either<string, Uri> Genre { get; set; }
    }
}
