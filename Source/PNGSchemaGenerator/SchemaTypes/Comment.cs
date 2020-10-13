namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Comment : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Comment";

        [DataMember(Name = "downvoteCount", Order = 2)]
        public OneOrMore<int?> DownvoteCount { get; set; }

        [DataMember(Name = "parentItem", Order = 3)]
        public OneOrMore<Question> ParentItem { get; set; }

        [DataMember(Name = "upvoteCount", Order = 4)]
        public OneOrMore<int?> UpvoteCount { get; set; }
    }
}
