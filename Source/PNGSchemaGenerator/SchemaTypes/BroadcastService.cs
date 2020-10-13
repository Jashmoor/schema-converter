namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BroadcastService : Service
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastService";

        [DataMember(Name = "broadcastAffiliateOf", Order = 2)]
        public OneOrMore<Organization> BroadcastAffiliateOf { get; set; }

        [DataMember(Name = "broadcastDisplayName", Order = 3)]
        public OneOrMore<string> BroadcastDisplayName { get; set; }

        [DataMember(Name = "broadcaster", Order = 4)]
        public OneOrMore<Organization> Broadcaster { get; set; }

        [DataMember(Name = "broadcastFrequency", Order = 5)]
        public Either<BroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        [DataMember(Name = "broadcastTimezone", Order = 6)]
        public OneOrMore<string> BroadcastTimezone { get; set; }

        [DataMember(Name = "callSign", Order = 7)]
        public OneOrMore<string> CallSign { get; set; }

        [DataMember(Name = "hasBroadcastChannel", Order = 8)]
        public OneOrMore<BroadcastChannel> HasBroadcastChannel { get; set; }

        [DataMember(Name = "inLanguage", Order = 9)]
        public Either<Language, string> InLanguage { get; set; }

        [DataMember(Name = "parentService", Order = 10)]
        public OneOrMore<BroadcastService> ParentService { get; set; }

        [DataMember(Name = "videoFormat", Order = 11)]
        public OneOrMore<string> VideoFormat { get; set; }
    }
}
