namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BroadcastChannel : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastChannel";

        [DataMember(Name = "broadcastChannelId", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> BroadcastChannelId { get; set; }

        [DataMember(Name = "broadcastFrequency", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<BroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        [DataMember(Name = "broadcastServiceTier", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> BroadcastServiceTier { get; set; }

        [DataMember(Name = "genre", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> Genre { get; set; }

        [DataMember(Name = "inBroadcastLineup", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CableOrSatelliteService> InBroadcastLineup { get; set; }

        [DataMember(Name = "providesBroadcastService", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BroadcastService> ProvidesBroadcastService { get; set; }
    }
}
