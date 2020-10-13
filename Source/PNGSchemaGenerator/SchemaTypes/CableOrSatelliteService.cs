namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class CableOrSatelliteService : Service
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CableOrSatelliteService";
    }
}
