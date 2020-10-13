﻿namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MonetaryAmountDistribution : QuantitativeAmountDistribution
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmountDistribution";

        [DataMember(Name = "currency", Order = 2)]
        public OneOrMore<string> Currency { get; set; }
    }
}
