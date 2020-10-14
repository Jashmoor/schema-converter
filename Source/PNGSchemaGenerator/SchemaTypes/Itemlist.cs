namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ItemList : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ItemList";

        [DataMember(Name = "itemListElement", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ListItem, string, Thing> ItemListElement { get; set; }

        /// <summary>
        /// Uses Enum Type ... ItemListOrder = ItemListOrder.ItemListOrderDescending ...
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ItemListOrderType?, string> ItemListOrder { get; set; }

        [DataMember(Name = "numberOfItems", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<int?> NumberOfItems { get; set; }
    }
}
