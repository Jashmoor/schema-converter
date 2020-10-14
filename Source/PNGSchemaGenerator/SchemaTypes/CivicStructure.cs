namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class CivicStructure : Place
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CivicStructure";

        [DataMember(Name = "openinghours", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> OpeningHours { get; set; }
    }
}
