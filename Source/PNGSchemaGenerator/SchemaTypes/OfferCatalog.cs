namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class OfferCatalog : ItemList
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OfferCatalog";
    }
}
