namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Photograph : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Photograph";
    }
}
