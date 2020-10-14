namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class PublicationEvent : Event
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationEvent";

        [DataMember(Name = "isAccessibleForFree", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public override OneOrMore<bool?> IsAccessibleForFree { get; set; }

        [DataMember(Name = "publishedBy", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> PublishedBy { get; set; }

        [DataMember(Name = "publishedOn", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<BroadcastService> PublishedOn { get; set; }
    }
}
