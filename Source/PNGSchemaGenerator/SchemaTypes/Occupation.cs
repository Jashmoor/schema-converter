namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Occupation : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Occupation";

        [DataMember(Name = "educationRequirements", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> EducationRequirements { get; set; }

        [DataMember(Name = "estimatedSalary", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MonetaryAmount, MonetaryAmountDistribution> EstimatedSalary { get; set; }

        [DataMember(Name = "experienceRequirements", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ExperienceRequirements { get; set; }

        [DataMember(Name = "occupationalCategory", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> OccupationalCategory { get; set; }

        [DataMember(Name = "qualifications", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Qualifications { get; set; }

        [DataMember(Name = "responsibilities", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Responsibilities { get; set; }

        [DataMember(Name = "skills", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Skills { get; set; }
    }
}
