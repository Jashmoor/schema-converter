namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SocialMediaPosting : Article
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SocialMediaPosting";

        [DataMember(Name = "sharedContent", Order = 306)]
        public OneOrMore<CreativeWork> SharedContent { get; set; }
    }
}
