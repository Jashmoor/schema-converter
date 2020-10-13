namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class EducationalOrganization : Organization
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalOrganization";

        [DataMember(Name = "alumni", Order = 2)]
        public override OneOrMore<Person> Alumni { get; set; }
    }
}
