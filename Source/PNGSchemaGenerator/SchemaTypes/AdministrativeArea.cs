namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AdministrativeArea : Place
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdministrativeArea";
    }
}
