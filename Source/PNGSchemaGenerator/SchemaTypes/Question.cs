namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Question : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Question";

        [DataMember(Name = "acceptedAnswer", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Answer, ItemList> AcceptedAnswer { get; set; }

        [DataMember(Name = "answerCount", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> AnswerCount { get; set; }

        [DataMember(Name = "downvoteCount", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> DownvoteCount { get; set; }

        [DataMember(Name = "suggestedAnswer", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Answer, ItemList> SuggestedAnswer { get; set; }

        [DataMember(Name = "upvoteCount", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> UpvoteCount { get; set; }
    }
}
