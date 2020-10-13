namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class JobPosting : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JobPosting";

        [DataMember(Name = "title", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Title { get; set; }

        [DataMember(Name = "applicationContact", Order = 4)]
        public OneOrMore<ContactPoint> ApplicationContact { get; set; }

        [DataMember(Name = "baseSalary", Order = 5)]
        public Either<MonetaryAmount, decimal?, PriceSpecification> BaseSalary { get; set; }

        [DataMember(Name = "datePosted", Order = 6)]
        public OneOrMore<DateTime?> DatePosted { get; set; }

        [DataMember(Name = "employmentType", Order = 7)]
        public OneOrMore<string> EmploymentType { get; set; }

        [DataMember(Name = "estimatedSalary", Order = 8)]
        public Either<MonetaryAmount, MonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        [DataMember(Name = "experienceRequirements", Order = 9)]
        public OneOrMore<string> ExperienceRequirements { get; set; }

        [DataMember(Name = "hiringOrganization", Order = 10)]
        public OneOrMore<Organization> HiringOrganization { get; set; }

        [DataMember(Name = "industry", Order = 11)]
        public OneOrMore<string> Industry { get; set; }

        [DataMember(Name = "jobBenefits", Order = 12)]
        public OneOrMore<string> JobBenefits { get; set; }

        [DataMember(Name = "jobLocation", Order = 13)]
        public OneOrMore<Place> JobLocation { get; set; }

        [DataMember(Name = "jobStartDate", Order = 14)]
        public Either<int?, DateTime?, string> JobStartDate { get; set; }

        [DataMember(Name = "occupationalCategory", Order = 15)]
        public OneOrMore<string> OccupationalCategory { get; set; }

        [DataMember(Name = "qualifications", Order = 16)]
        public OneOrMore<string> Qualifications { get; set; }

        [DataMember(Name = "relevantOccupation", Order = 17)]
        public OneOrMore<Occupation> RelevantOccupation { get; set; }

        [DataMember(Name = "responsibilities", Order = 18)]
        public OneOrMore<string> Responsibilities { get; set; }

        [DataMember(Name = "salaryCurrency", Order = 19)]
        public OneOrMore<string> SalaryCurrency { get; set; }

        [DataMember(Name = "skills", Order = 20)]
        public OneOrMore<string> Skills { get; set; }

        [DataMember(Name = "validThrough", Order = 21)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        [DataMember(Name = "workHours", Order = 22)]
        public OneOrMore<string> WorkHours { get; set; }
    }
}
