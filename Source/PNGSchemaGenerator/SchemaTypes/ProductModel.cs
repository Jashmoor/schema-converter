namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ProductModel : Product
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProductModel";

        [DataMember(Name = "isVariantOf", Order = 2)]
        public OneOrMore<ProductModel> IsVariantOf { get; set; }

        [DataMember(Name = "predecessorOf", Order = 3)]
        public OneOrMore<ProductModel> PredecessorOf { get; set; }

        [DataMember(Name = "successorOf", Order = 4)]
        public OneOrMore<ProductModel> SuccessorOf { get; set; }
    }
}
