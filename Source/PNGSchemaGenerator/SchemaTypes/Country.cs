namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Country : AdministrativeArea
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Country";
    }
}
