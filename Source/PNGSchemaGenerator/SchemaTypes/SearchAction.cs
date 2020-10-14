namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SearchAction : Action
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        [DataMember(Name = "query", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Query { get; set; }

        [DataMember(Name = "query-input", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, PropertyValueSpecification> QueryInput { get; set; }
    }
}
