namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataFeedItem : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeedItem";

        [DataMember(Name = "dateCreated", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        [DataMember(Name = "dateDeleted", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DateDeleted { get; set; }

        [DataMember(Name = "dateModified", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        [DataMember(Name = "item", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Thing> Item { get; set; }
    }
}
