﻿namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Website : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebSite";

        [DataMember(Name = "issn", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Issn { get; set; }
    }
}
