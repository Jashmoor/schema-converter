namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Blog : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Blog";

        [DataMember(Name = "blogPost", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BlogPosting> BlogPost { get; set; }

        [DataMember(Name = "issn", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Issn { get; set; }
    }
}
