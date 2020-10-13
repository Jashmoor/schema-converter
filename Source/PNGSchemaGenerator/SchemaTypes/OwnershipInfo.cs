namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class OwnershipInfo : StructuredValue
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OwnershipInfo";

        [DataMember(Name = "acquiredFrom", Order = 2)]
        public Either<Organization, Person> AcquiredFrom { get; set; }

        [DataMember(Name = "ownedFrom", Order = 3)]
        public OneOrMore<DateTimeOffset?> OwnedFrom { get; set; }

        [DataMember(Name = "ownedThrough", Order = 4)]
        public OneOrMore<DateTimeOffset?> OwnedThrough { get; set; }

        [DataMember(Name = "typeOfGood", Order = 5)]
        public Either<Product, Service> TypeOfGood { get; set; }
    }
}
