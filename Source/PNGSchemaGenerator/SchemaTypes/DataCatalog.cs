namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataCatalog : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataCatalog";

        [DataMember(Name = "dataset", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Dataset> Dataset { get; set; }

        [DataMember(Name = "measurementTechnique", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> MeasurementTechnique { get; set; }
    }
}
