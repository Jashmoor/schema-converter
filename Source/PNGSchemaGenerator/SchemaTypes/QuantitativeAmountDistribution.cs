namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class QuantitativeAmountDistribution : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeAmountDistribution";

        [DataMember(Name = "median", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> Median { get; set; }
    }
}
