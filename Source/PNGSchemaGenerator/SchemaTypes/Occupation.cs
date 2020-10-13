namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Occupation : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Occupation";

        [DataMember(Name = "educationRequirements", Order = 2)]
        public OneOrMore<string> EducationRequirements { get; set; }

        [DataMember(Name = "estimatedSalary", Order = 3)]
        public Either<MonetaryAmount, MonetaryAmountDistribution> EstimatedSalary { get; set; }

        [DataMember(Name = "experienceRequirements", Order = 4)]
        public OneOrMore<string> ExperienceRequirements { get; set; }

        [DataMember(Name = "occupationalCategory", Order = 5)]
        public OneOrMore<string> OccupationalCategory { get; set; }

        [DataMember(Name = "qualifications", Order = 6)]
        public OneOrMore<string> Qualifications { get; set; }

        [DataMember(Name = "responsibilities", Order = 7)]
        public OneOrMore<string> Responsibilities { get; set; }

        [DataMember(Name = "skills", Order = 8)]
        public OneOrMore<string> Skills { get; set; }
    }
}
