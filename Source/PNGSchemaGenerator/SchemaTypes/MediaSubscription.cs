namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class MediaSubscription : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaSubscription";

        [DataMember(Name = "authenticator", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Organization> Authenticator { get; set; }

        [DataMember(Name = "expectsAcceptanceOf", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Offer> ExpectsAcceptanceOf { get; set; }
    }
}
