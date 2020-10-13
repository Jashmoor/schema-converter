namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SpeakableSpecification : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpeakableSpecification";

        [DataMember(Name = "cssSelector", Order = 206)]
        public OneOrMore<string> CssSelector { get; set; }

        [DataMember(Name = "xpath", Order = 207)]
        public OneOrMore<string> Xpath { get; set; }
    }
}
