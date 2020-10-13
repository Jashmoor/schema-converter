namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MediaSubscription : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaSubscription";

        [DataMember(Name = "authenticator", Order = 2)]
        public OneOrMore<Organization> Authenticator { get; set; }

        [DataMember(Name = "expectsAcceptanceOf", Order = 3)]
        public OneOrMore<Offer> ExpectsAcceptanceOf { get; set; }
    }
}
