namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MonetaryAmountDistribution : QuantitativeAmountDistribution
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmountDistribution";

        [DataMember(Name = "currency", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Currency { get; set; }
    }
}
