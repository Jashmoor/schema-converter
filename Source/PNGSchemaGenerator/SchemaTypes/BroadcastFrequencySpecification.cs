namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BroadcastFrequencySpecification : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastFrequencySpecification";

        [DataMember(Name = "broadcastFrequencyValue", Order = 2)]
        public Either<double?, QuantitativeValue> BroadcastFrequencyValue { get; set; }

        [DataMember(Name = "broadcastSignalModulation", Order = 3)]
        public OneOrMore<string> BroadcastSignalModulation { get; set; }

        [DataMember(Name = "broadcastSubChannel", Order = 4)]
        public OneOrMore<string> BroadcastSubChannel { get; set; }
    }
}
