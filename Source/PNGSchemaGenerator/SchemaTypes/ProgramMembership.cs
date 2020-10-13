namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ProgramMembership : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProgramMembership";

        [DataMember(Name = "hostingOrganization", Order = 2)]
        public OneOrMore<Organization> HostingOrganization { get; set; }

        [DataMember(Name = "member", Order = 3)]
        public Either<Organization, Person> Member { get; set; }

        [DataMember(Name = "membershipNumber", Order = 4)]
        public OneOrMore<string> MembershipNumber { get; set; }

        [DataMember(Name = "membershipPointsEarned", Order = 5)]
        public Either<double?, QuantitativeValue> MembershipPointsEarned { get; set; }

        [DataMember(Name = "programName", Order = 6)]
        public OneOrMore<string> ProgramName { get; set; }
    }
}
