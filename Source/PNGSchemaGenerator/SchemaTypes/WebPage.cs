namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class WebPage : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPage";

        [DataMember(Name = "breadcrumb", Order = 206)]
        public Either<BreadcrumbList, string> Breadcrumb { get; set; }

        [DataMember(Name = "lastReviewed", Order = 207)]
        public Either<int?, DateTime?> LastReviewed { get; set; }

        [DataMember(Name = "mainContentOfPage", Order = 208)]
        public OneOrMore<WebPageElement> MainContentOfPage { get; set; }

        [DataMember(Name = "primaryImageOfPage", Order = 209)]
        public OneOrMore<ImageObject> PrimaryImageOfPage { get; set; }

        [DataMember(Name = "relatedLink", Order = 210)]
        public OneOrMore<Uri> RelatedLink { get; set; }

        [DataMember(Name = "reviewedBy", Order = 211)]
        public Either<Organization, Person> ReviewedBy { get; set; }

        [DataMember(Name = "significantLink", Order = 212)]
        public OneOrMore<Uri> SignificantLink { get; set; }
    }
}
