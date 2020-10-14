namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ImageObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageObject";

        [DataMember(Name = "caption", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "exifData", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PropertyValue, string> ExifData { get; set; }

        [DataMember(Name = "representativeOfPage", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<bool?> RepresentativeOfPage { get; set; }

        [DataMember(Name = "thumbnail", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ImageObject> Thumbnail { get; set; }
    }
}
