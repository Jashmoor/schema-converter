namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Article : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Article";

        [DataMember(Name = "articleBody", Order = 2)]
        public OneOrMore<string> ArticleBody { get; set; }

        [DataMember(Name = "articleSection", Order = 3)]
        public OneOrMore<string> ArticleSection { get; set; }

        [DataMember(Name = "backstory", Order = 4)]
        public Either<CreativeWork, string> Backstory { get; set; }

        [DataMember(Name = "pageEnd", Order = 5)]
        public Either<int?, string> PageEnd { get; set; }

        [DataMember(Name = "pageStart", Order = 6)]
        public Either<int?, string> PageStart { get; set; }

        [DataMember(Name = "pagination", Order = 7)]
        public OneOrMore<string> Pagination { get; set; }

        [DataMember(Name = "speakable", Order = 8)]
        public Either<SpeakableSpecification, Uri> Speakable { get; set; }
    }
}
