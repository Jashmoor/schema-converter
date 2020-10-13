namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ListItem : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        [DataMember(Name = "item", Order = 2)]
        public OneOrMore<Thing> Item { get; set; }

        [DataMember(Name = "nextItem", Order = 3)]
        public OneOrMore<ListItem> NextItem { get; set; }

        [DataMember(Name = "position", Order = 4)]
        public Either<int?, string> Position { get; set; }

        [DataMember(Name = "previousItem", Order = 5)]
        public OneOrMore<ListItem> PreviousItem { get; set; }
    }
}
