namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BreadcrumbList : ItemList
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BreadcrumbList";
    }
}
