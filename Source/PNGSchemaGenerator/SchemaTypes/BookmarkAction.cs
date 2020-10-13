namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BookmarkAction : OrganizeAction
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BookmarkAction";
    }
}
