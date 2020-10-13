namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class WebContent : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebContent";
    }
}
