namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class ServiceChannel : Intangible
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ServiceChannel";

        [DataMember(Name = "availableLanguage", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<Language, string> AvailableLanguage { get; set; }

        [DataMember(Name = "processingTime", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<TimeSpan?> ProcessingTime { get; set; }

        [DataMember(Name = "providesService", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Service> ProvidesService { get; set; }

        [DataMember(Name = "serviceLocation", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Place> ServiceLocation { get; set; }

        [DataMember(Name = "servicePhone", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPoint> ServicePhone { get; set; }

        [DataMember(Name = "servicePostalAddress", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<PostalAddress> ServicePostalAddress { get; set; }

        [DataMember(Name = "serviceSmsNumber", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<ContactPoint> ServiceSmsNumber { get; set; }

        [DataMember(Name = "serviceUrl", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> ServiceUrl { get; set; }
    }
}
