namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataCatalog : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataCatalog";

        [DataMember(Name = "dataset", Order = 2)]
        public OneOrMore<Dataset> Dataset { get; set; }

        [DataMember(Name = "measurementTechnique", Order = 3)]
        public Either<string, Uri> MeasurementTechnique { get; set; }
    }
}
