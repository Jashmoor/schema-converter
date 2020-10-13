namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PerformingGroup : Organization
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformingGroup";
    }
}
