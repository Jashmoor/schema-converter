namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Dataset : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dataset";

        [DataMember(Name = "distribution", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DataDownload> Distribution { get; set; }

        [DataMember(Name = "includedInDataCatalog", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DataCatalog> IncludedInDataCatalog { get; set; }

        [DataMember(Name = "issn", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Issn { get; set; }

        [DataMember(Name = "measurementTechnique", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> MeasurementTechnique { get; set; }

        [DataMember(Name = "variableMeasured", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PropertyValue, string> VariableMeasured { get; set; }

        [DataMember(Name = "variablesMeasured", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PropertyValue, string> VariablesMeasured { get; set; }
    }
}
