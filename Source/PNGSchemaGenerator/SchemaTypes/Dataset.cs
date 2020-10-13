namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Dataset : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dataset";

        [DataMember(Name = "distribution", Order = 2)]
        public OneOrMore<DataDownload> Distribution { get; set; }

        [DataMember(Name = "includedInDataCatalog", Order = 3)]
        public OneOrMore<DataCatalog> IncludedInDataCatalog { get; set; }

        [DataMember(Name = "issn", Order = 4)]
        public OneOrMore<string> Issn { get; set; }

        [DataMember(Name = "measurementTechnique", Order = 5)]
        public Either<string, Uri> MeasurementTechnique { get; set; }

        [DataMember(Name = "variableMeasured", Order = 6)]
        public Either<PropertyValue, string> VariableMeasured { get; set; }

        [DataMember(Name = "variablesMeasured", Order = 7)]
        public Either<PropertyValue, string> VariablesMeasured { get; set; }
    }
}
