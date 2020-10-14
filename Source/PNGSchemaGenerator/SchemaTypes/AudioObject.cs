namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AudioObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AudioObject";

        [DataMember(Name = "caption", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "transcript", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Transcript { get; set; }
    }
}
