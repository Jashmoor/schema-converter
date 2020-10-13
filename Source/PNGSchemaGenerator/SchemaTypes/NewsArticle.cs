namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class NewsArticle : Article
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NewsArticle";

        [DataMember(Name = "dateline", Order = 2)]
        public OneOrMore<string> Dateline { get; set; }

        [DataMember(Name = "printColumn", Order = 3)]
        public OneOrMore<string> PrintColumn { get; set; }

        [DataMember(Name = "printEdition", Order = 4)]
        public OneOrMore<string> PrintEdition { get; set; }

        [DataMember(Name = "printPage", Order = 5)]
        public OneOrMore<string> PrintPage { get; set; }

        [DataMember(Name = "printSection", Order = 6)]
        public OneOrMore<string> PrintSection { get; set; }
    }
}
