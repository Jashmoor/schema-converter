namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class QuantitativeValue : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeValue";

        [DataMember(Name = "additionalProperty", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PropertyValue> AdditionalProperty { get; set; }

        [DataMember(Name = "maxValue", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "unitCode", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> UnitCode { get; set; }

        [DataMember(Name = "unitText", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> UnitText { get; set; }

        [DataMember(Name = "value", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<bool?, double?, StructuredValue, string> Value { get; set; }

        [DataMember(Name = "valueReference", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PropertyValue, QuantitativeValue, StructuredValue> ValueReference { get; set; }
    }
}
