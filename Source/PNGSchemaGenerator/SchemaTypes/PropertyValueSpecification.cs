namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PropertyValueSpecification : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PropertyValueSpecification";

        [DataMember(Name = "defaultValue", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Thing> DefaultValue { get; set; }

        [DataMember(Name = "maxValue", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "multipleValues", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> MultipleValues { get; set; }

        [DataMember(Name = "readonlyValue", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> ReadonlyValue { get; set; }

        [DataMember(Name = "stepValue", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> StepValue { get; set; }

        [DataMember(Name = "valueMaxLength", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> ValueMaxLength { get; set; }

        [DataMember(Name = "valueMinLength", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> ValueMinLength { get; set; }

        [DataMember(Name = "valueName", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ValueName { get; set; }

        [DataMember(Name = "valuePattern", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ValuePattern { get; set; }

        [DataMember(Name = "valueRequired", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> ValueRequired { get; set; }
    }
}
