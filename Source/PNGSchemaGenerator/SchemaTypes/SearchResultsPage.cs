namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SearchResultsPage : WebPage
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchResultsPage";
    }
}
