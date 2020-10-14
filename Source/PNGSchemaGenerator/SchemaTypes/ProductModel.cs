namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ProductModel : Product
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProductModel";

        [DataMember(Name = "isVariantOf", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ProductModel> IsVariantOf { get; set; }

        [DataMember(Name = "predecessorOf", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ProductModel> PredecessorOf { get; set; }

        [DataMember(Name = "successorOf", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ProductModel> SuccessorOf { get; set; }
    }
}
