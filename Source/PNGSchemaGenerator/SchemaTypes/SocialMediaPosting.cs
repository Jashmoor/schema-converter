namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SocialMediaPosting : Article
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SocialMediaPosting";

        [DataMember(Name = "sharedContent", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> SharedContent { get; set; }
    }
}
