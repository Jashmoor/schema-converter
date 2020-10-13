namespace PNGSchemaGenerator.SchemaTypes
{
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
        public OneOrMore<decimal?> AmountOfThisGood { get; set; }

        /// <summary>
        /// Enum type BusinessFunction
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 3)]
        public OneOrMore<BusinessFunction?> BusinessFunction { get; set; }

        [DataMember(Name = "typeOfGood", Order = 4)]
        public Either<Product, Service> TypeOfGood { get; set; }

        [DataMember(Name = "unitCode", Order = 5)]
        public Either<string, Uri> UnitCode { get; set; }

        [DataMember(Name = "unitText", Order = 6)]
        public OneOrMore<string> UnitText { get; set; }
    }
}
