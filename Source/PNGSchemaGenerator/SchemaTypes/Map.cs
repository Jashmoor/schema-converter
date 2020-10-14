namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
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
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<MapCategoryType?> MapType { get; set; }
    }
}
