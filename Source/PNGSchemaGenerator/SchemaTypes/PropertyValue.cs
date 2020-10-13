namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PropertyValue : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValue";

        [DataMember(Name = "maxValue", Order = 2)]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "measurementTechnique", Order = 3)]
        public Either<string, Uri> MeasurementTechnique { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "propertyID", Order = 5)]
        public Either<string, Uri> PropertyID { get; set; }

        [DataMember(Name = "unitCode", Order = 6)]
        public Either<string, Uri> UnitCode { get; set; }

        [DataMember(Name = "unitText", Order = 7)]
        public OneOrMore<string> UnitText { get; set; }

        [DataMember(Name = "value", Order = 8)]
        public Either<bool?, double?, StructuredValue, string> Value { get; set; }

        [DataMember(Name = "valueReference", Order = 9)]
        public Either<PropertyValue, QuantitativeValue, StructuredValue> ValueReference { get; set; }
    }
}
