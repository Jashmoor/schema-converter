namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Thing : JsonBaseObject
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thing";

        [DataMember(Name = "name", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Name { get; set; }

        [DataMember(Name = "description", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Description { get; set; }

        [DataMember(Name = "additionalType", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> AdditionalType { get; set; }

        [DataMember(Name = "alternateName", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AlternateName { get; set; }

        [DataMember(Name = "identifier", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<PropertyValue, string, Uri> Identifier { get; set; }

        [DataMember(Name = "image", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Image { get; set; }

        [DataMember(Name = "mainEntityOfPage", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<CreativeWork, Uri> MainEntityOfPage { get; set; }

        [DataMember(Name = "potentialAction", Order = 14)]
        public OneOrMore<Action> PotentialAction { get; set; }

        [DataMember(Name = "sameAs", Order = 15)]
        public OneOrMore<Uri> SameAs { get; set; }

        [DataMember(Name = "url", Order = 17)]
        public OneOrMore<Uri> Url { get; set; }

        #region Methods
        private readonly JsonSerializerSettings _Settings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter> { new StringEnumConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml
        };

        public override string ToString() => JsonConvert.SerializeObject(this, _Settings);
        #endregion
    }
}
