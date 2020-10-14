namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ProgramMembership : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProgramMembership";

        [DataMember(Name = "hostingOrganization", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> HostingOrganization { get; set; }

        [DataMember(Name = "member", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "membershipNumber", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> MembershipNumber { get; set; }

        [DataMember(Name = "membershipPointsEarned", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, QuantitativeValue> MembershipPointsEarned { get; set; }

        [DataMember(Name = "programName", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ProgramName { get; set; }
    }
}
