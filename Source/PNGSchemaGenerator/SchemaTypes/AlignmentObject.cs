namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AlignmentObject : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AlignmentObject";

        [DataMember(Name = "alignmentType", Order = 2)]
        public OneOrMore<string> AlignmentType { get; set; }

        [DataMember(Name = "educationalFramework", Order = 3)]
        public OneOrMore<string> EducationalFramework { get; set; }

        [DataMember(Name = "targetDescription", Order = 4)]
        public OneOrMore<string> TargetDescription { get; set; }

        [DataMember(Name = "targetName", Order = 5)]
        public OneOrMore<string> TargetName { get; set; }

        [DataMember(Name = "targetUrl", Order = 6)]
        public OneOrMore<Uri> TargetUrl { get; set; }
    }
}
