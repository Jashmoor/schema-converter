namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Constants;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Map : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Map";

        /// <summary>
        /// Enum type MapCategoryType
        /// </summary>
        [DataMember(Name = "mapType", Order = 2)]
        public OneOrMore<MapCategoryType?> MapType { get; set; }
    }
}
