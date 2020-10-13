namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class GovernmentService : Service
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentService";

        [DataMember(Name = "serviceOperator", Order = 2)]
        public OneOrMore<Organization> ServiceOperator { get; set; }
    }
}
