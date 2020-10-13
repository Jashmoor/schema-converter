namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Intangible : Thing
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Intangible";
    }
}
