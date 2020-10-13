namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Blog : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Blog";

        [DataMember(Name = "blogPost", Order = 2)]
        public OneOrMore<BlogPosting> BlogPost { get; set; }

        [DataMember(Name = "issn", Order = 3)]
        public OneOrMore<string> Issn { get; set; }
    }
}
