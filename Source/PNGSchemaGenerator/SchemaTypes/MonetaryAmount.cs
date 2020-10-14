namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MonetaryAmount : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmount";

        [DataMember(Name = "currency", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Currency { get; set; }

        [DataMember(Name = "maxValue", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "validFrom", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
