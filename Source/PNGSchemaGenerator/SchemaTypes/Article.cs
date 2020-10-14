namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Article : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Article";

        [DataMember(Name = "articleBody", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ArticleBody { get; set; }

        [DataMember(Name = "articleSection", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ArticleSection { get; set; }

        [DataMember(Name = "backstory", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, string> Backstory { get; set; }

        [DataMember(Name = "pageEnd", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, string> PageEnd { get; set; }

        [DataMember(Name = "pageStart", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, string> PageStart { get; set; }

        [DataMember(Name = "pagination", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Pagination { get; set; }

        [DataMember(Name = "speakable", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<SpeakableSpecification, Uri> Speakable { get; set; }
    }
}
