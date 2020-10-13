namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AboutPage : WebPage
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AboutPage";
    }
}
