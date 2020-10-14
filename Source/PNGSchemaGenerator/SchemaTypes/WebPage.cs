namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class WebPage : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPage";

        [DataMember(Name = "breadcrumb", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<BreadcrumbList, string> Breadcrumb { get; set; }

        [DataMember(Name = "lastReviewed", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<int?, DateTime?> LastReviewed { get; set; }

        [DataMember(Name = "mainContentOfPage", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<WebPageElement> MainContentOfPage { get; set; }

        [DataMember(Name = "primaryImageOfPage", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ImageObject> PrimaryImageOfPage { get; set; }

        [DataMember(Name = "relatedLink", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> RelatedLink { get; set; }

        [DataMember(Name = "reviewedBy", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Organization, Person> ReviewedBy { get; set; }

        [DataMember(Name = "significantLink", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> SignificantLink { get; set; }
    }
}
