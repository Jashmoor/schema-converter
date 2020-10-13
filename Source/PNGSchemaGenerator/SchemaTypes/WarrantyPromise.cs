namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class WarrantyPromise : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WarrantyPromise";

        [DataMember(Name = "durationOfWarranty", Order = 2)]
        public OneOrMore<QuantitativeValue> DurationOfWarranty { get; set; }

        [DataMember(Name = "warrantyScope", Order = 3)]
        public OneOrMore<WarrantyScope?> WarrantyScope { get; set; }
    }
}
