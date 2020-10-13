namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Clip : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Clip";
    }
}
