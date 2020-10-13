namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ImageObject : MediaObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageObject";

        [DataMember(Name = "caption", Order = 306)]
        public Either<MediaObject, string> Caption { get; set; }

        [DataMember(Name = "exifData", Order = 307)]
        public Either<PropertyValue, string> ExifData { get; set; }

        [DataMember(Name = "representativeOfPage", Order = 308)]
        public OneOrMore<bool?> RepresentativeOfPage { get; set; }

        [DataMember(Name = "thumbnail", Order = 309)]
        public OneOrMore<ImageObject> Thumbnail { get; set; }
    }
}
