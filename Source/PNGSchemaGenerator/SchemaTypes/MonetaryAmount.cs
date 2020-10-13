namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MonetaryAmount : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmount";

        [DataMember(Name = "currency", Order = 2)]
        public OneOrMore<string> Currency { get; set; }

        [DataMember(Name = "maxValue", Order = 3)]
        public OneOrMore<double?> MaxValue { get; set; }

        [DataMember(Name = "minValue", Order = 4)]
        public OneOrMore<double?> MinValue { get; set; }

        [DataMember(Name = "validFrom", Order = 5)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        [DataMember(Name = "validThrough", Order = 6)]
        public Either<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }
}
