namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Language : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Language";
    }
}
