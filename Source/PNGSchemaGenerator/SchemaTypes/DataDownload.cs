namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataDownload : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataDownload";

        [DataMember(Name = "measurementTechnique", Order = 306)]
        public Either<string, Uri> MeasurementTechnique { get; set; }
    }
}
