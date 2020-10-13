namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BlogPosting : SocialMediaPosting
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BlogPosting";
    }
}
