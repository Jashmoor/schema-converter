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
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPoint> ApplicationContact { get; set; }

        [DataMember(Name = "baseSalary", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MonetaryAmount, decimal?, PriceSpecification> BaseSalary { get; set; }

        [DataMember(Name = "datePosted", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DateTime?> DatePosted { get; set; }

        [DataMember(Name = "employmentType", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> EmploymentType { get; set; }

        [DataMember(Name = "estimatedSalary", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MonetaryAmount, MonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        [DataMember(Name = "experienceRequirements", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ExperienceRequirements { get; set; }

        [DataMember(Name = "hiringOrganization", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> HiringOrganization { get; set; }

        [DataMember(Name = "industry", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Industry { get; set; }

        [DataMember(Name = "jobBenefits", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> JobBenefits { get; set; }

        [DataMember(Name = "jobLocation", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> JobLocation { get; set; }

        [DataMember(Name = "jobStartDate", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, string> JobStartDate { get; set; }

        [DataMember(Name = "occupationalCategory", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> OccupationalCategory { get; set; }

        [DataMember(Name = "qualifications", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Qualifications { get; set; }

        [DataMember(Name = "relevantOccupation", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Occupation> RelevantOccupation { get; set; }

        [DataMember(Name = "responsibilities", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Responsibilities { get; set; }

        [DataMember(Name = "salaryCurrency", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> SalaryCurrency { get; set; }

        [DataMember(Name = "skills", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Skills { get; set; }

        [DataMember(Name = "validThrough", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        [DataMember(Name = "workHours", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> WorkHours { get; set; }
    }
}
