namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class TypeAndQuantityNode : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TypeAndQuantityNode";

        [DataMember(Name = "amountOfThisGood", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<decimal?> AmountOfThisGood { get; set; }

        /// <summary>
        /// Enum type BusinessFunction
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BusinessFunction?> BusinessFunction { get; set; }

        [DataMember(Name = "typeOfGood", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Product, Service> TypeOfGood { get; set; }

        [DataMember(Name = "unitCode", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> UnitCode { get; set; }

        [DataMember(Name = "unitText", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> UnitText { get; set; }
    }
}
