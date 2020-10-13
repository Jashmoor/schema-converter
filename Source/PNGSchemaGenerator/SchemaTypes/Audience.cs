namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Audience : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audience";

        [DataMember(Name = "audienceType", Order = 2)]
        public OneOrMore<string> AudienceType { get; set; }

        [DataMember(Name = "geographicArea", Order = 3)]
        public OneOrMore<AdministrativeArea> GeographicArea { get; set; }
    }
}
