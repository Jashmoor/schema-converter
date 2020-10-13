namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class QuantitativeValue : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeValue";

        [DataMember(Name = "additionalProperty", Order = 2)]
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "maxValue", Order = 3)]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "unitCode", Order = 5)]
        public Either<string, Uri> UnitCode { get; set; }

        [DataMember(Name = "unitText", Order = 6)]
        public OneOrMore<string> UnitText { get; set; }

        [DataMember(Name = "value", Order = 7)]
        public Either<bool?, double?, StructuredValue, string> Value { get; set; }

        [DataMember(Name = "valueReference", Order = 8)]
        public Either<PropertyValue, QuantitativeValue, StructuredValue> ValueReference { get; set; }
    }
}
