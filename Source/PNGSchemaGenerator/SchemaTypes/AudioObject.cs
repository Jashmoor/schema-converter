namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AudioObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AudioObject";

        [DataMember(Name = "caption", Order = 2)]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "transcript", Order = 3)]
        public OneOrMore<string> Transcript { get; set; }
    }
}
