namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class DataFeed : Dataset
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeed";

        [DataMember(Name = "dataFeedElement", Order = 2)]
        public Either<DataFeedItem, string, Thing> DataFeedElement { get; set; }
    }
}
