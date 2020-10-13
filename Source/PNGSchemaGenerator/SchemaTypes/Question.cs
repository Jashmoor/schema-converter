namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Question : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Question";

        [DataMember(Name = "acceptedAnswer", Order = 2)]
        public Either<Answer, ItemList> AcceptedAnswer { get; set; }

        [DataMember(Name = "answerCount", Order = 3)]
        public OneOrMore<int?> AnswerCount { get; set; }

        [DataMember(Name = "downvoteCount", Order = 4)]
        public OneOrMore<int?> DownvoteCount { get; set; }

        [DataMember(Name = "suggestedAnswer", Order = 5)]
        public Either<Answer, ItemList> SuggestedAnswer { get; set; }

        [DataMember(Name = "upvoteCount", Order = 6)]
        public OneOrMore<int?> UpvoteCount { get; set; }
    }
}
