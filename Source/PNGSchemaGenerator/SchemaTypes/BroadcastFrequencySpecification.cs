namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BroadcastFrequencySpecification : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastFrequencySpecification";

        [DataMember(Name = "broadcastFrequencyValue", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<double?, QuantitativeValue> BroadcastFrequencyValue { get; set; }

        [DataMember(Name = "broadcastSignalModulation", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> BroadcastSignalModulation { get; set; }

        [DataMember(Name = "broadcastSubChannel", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> BroadcastSubChannel { get; set; }
    }
}
