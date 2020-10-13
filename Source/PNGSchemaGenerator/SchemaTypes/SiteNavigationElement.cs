namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SiteNavigationElement : WebPageElement
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SiteNavigationElement";
    }
}
