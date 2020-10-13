namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ItemList : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ItemList";

        [DataMember(Name = "itemListElement", Order = 2)]
        public Either<ListItem, string, Thing> ItemListElement { get; set; }

        /// <summary>
        /// Uses Enum Type ... ItemListOrder = ItemListOrder.ItemListOrderDescending ...
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 3)]
        public Either<ItemListOrderType?, string> ItemListOrder { get; set; }

        [DataMember(Name = "numberOfItems", Order = 4)]
        public OneOrMore<int?> NumberOfItems { get; set; }
    }
}
