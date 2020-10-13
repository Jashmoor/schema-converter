namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class OrganizeAction : Action
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizeAction";
    }
}
