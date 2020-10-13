namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BroadcastChannel : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastChannel";

        [DataMember(Name = "broadcastChannelId", Order = 206)]
        public OneOrMore<string> BroadcastChannelId { get; set; }

        [DataMember(Name = "broadcastFrequency", Order = 207)]
        public Either<BroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        [DataMember(Name = "broadcastServiceTier", Order = 208)]
        public OneOrMore<string> BroadcastServiceTier { get; set; }

        [DataMember(Name = "genre", Order = 209)]
        public Either<string, Uri> Genre { get; set; }

        [DataMember(Name = "inBroadcastLineup", Order = 210)]
        public OneOrMore<CableOrSatelliteService> InBroadcastLineup { get; set; }

        [DataMember(Name = "providesBroadcastService", Order = 211)]
        public OneOrMore<BroadcastService> ProvidesBroadcastService { get; set; }
    }
}
