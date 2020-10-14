namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class WarrantyPromise : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WarrantyPromise";

        [DataMember(Name = "durationOfWarranty", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<QuantitativeValue> DurationOfWarranty { get; set; }

        [DataMember(Name = "warrantyScope", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<WarrantyScope?> WarrantyScope { get; set; }
    }
}
