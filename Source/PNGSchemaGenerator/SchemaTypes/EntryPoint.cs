namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class EntryPoint : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EntryPoint";

        [DataMember(Name = "actionApplication", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<SoftwareApplication> ActionApplication { get; set; }

        [DataMember(Name = "actionPlatform", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> ActionPlatform { get; set; }

        [DataMember(Name = "contentType", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ContentType { get; set; }

        [DataMember(Name = "encodingType", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> EncodingType { get; set; }

        [DataMember(Name = "httpMethod", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> HttpMethod { get; set; }

        [DataMember(Name = "urlTemplate", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> UrlTemplate { get; set; }
    }
}
