namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataDownload : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataDownload";

        [DataMember(Name = "measurementTechnique", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> MeasurementTechnique { get; set; }
    }
}
