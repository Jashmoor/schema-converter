namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class InteractionCounter : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractionCounter";

        [DataMember(Name = "interactionService", Order = 2)]
        public Either<SoftwareApplication, Website> InteractionService { get; set; }

        [DataMember(Name = "interactionType", Order = 3)]
        public OneOrMore<Action> InteractionType { get; set; }

        [DataMember(Name = "userInteractionCount", Order = 4)]
        public OneOrMore<int?> UserInteractionCount { get; set; }
    }
}
