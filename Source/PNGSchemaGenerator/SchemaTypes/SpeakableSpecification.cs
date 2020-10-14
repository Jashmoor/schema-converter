namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SpeakableSpecification : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpeakableSpecification";

        [DataMember(Name = "cssSelector", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CssSelector { get; set; }

        [DataMember(Name = "xpath", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Xpath { get; set; }
    }
}
