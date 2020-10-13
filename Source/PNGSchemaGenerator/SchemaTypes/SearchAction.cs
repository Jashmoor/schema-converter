namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SearchAction : Action
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        [DataMember(Name = "query", Order = 2)]
        public OneOrMore<string> Query { get; set; }

        [DataMember(Name = "query-input", Order = 3)]
        public Either<string, PropertyValueSpecification> QueryInput { get; set; }
    }
}
