namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class InteractionCounter : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractionCounter";

        [DataMember(Name = "interactionService", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<SoftwareApplication, Website> InteractionService { get; set; }

        [DataMember(Name = "interactionType", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Action> InteractionType { get; set; }

        [DataMember(Name = "userInteractionCount", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> UserInteractionCount { get; set; }
    }
}
