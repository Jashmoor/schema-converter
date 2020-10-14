namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AlignmentObject : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AlignmentObject";

        [DataMember(Name = "alignmentType", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AlignmentType { get; set; }

        [DataMember(Name = "educationalFramework", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> EducationalFramework { get; set; }

        [DataMember(Name = "targetDescription", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TargetDescription { get; set; }

        [DataMember(Name = "targetName", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> TargetName { get; set; }

        [DataMember(Name = "targetUrl", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> TargetUrl { get; set; }
    }
}
