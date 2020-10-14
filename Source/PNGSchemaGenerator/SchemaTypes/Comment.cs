namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Comment : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Comment";

        [DataMember(Name = "downvoteCount", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> DownvoteCount { get; set; }

        [DataMember(Name = "parentItem", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Question> ParentItem { get; set; }

        [DataMember(Name = "upvoteCount", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> UpvoteCount { get; set; }
    }
}
