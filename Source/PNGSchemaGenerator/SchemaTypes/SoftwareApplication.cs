namespace PNGSchemaGenerator.SchemaTypes
{
    using Newtonsoft.Json;
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SoftwareApplication : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareApplication";

        [DataMember(Name = "applicationCategory", Order = 2)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> ApplicationCategory { get; set; }

        [DataMember(Name = "applicationSubCategory", Order = 3)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> ApplicationSubCategory { get; set; }

        [DataMember(Name = "applicationSuite", Order = 4)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ApplicationSuite { get; set; }

        [DataMember(Name = "availableOnDevice", Order = 5)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> AvailableOnDevice { get; set; }

        [DataMember(Name = "countriesNotSupported", Order = 6)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CountriesNotSupported { get; set; }

        [DataMember(Name = "countriesSupported", Order = 7)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> CountriesSupported { get; set; }

        [DataMember(Name = "downloadUrl", Order = 8)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> DownloadUrl { get; set; }

        [DataMember(Name = "featureList", Order = 9)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> FeatureList { get; set; }

        [DataMember(Name = "fileSize", Order = 10)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> FileSize { get; set; }

        [DataMember(Name = "installUrl", Order = 11)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<Uri> InstallUrl { get; set; }

        [DataMember(Name = "memoryRequirements", Order = 12)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> MemoryRequirements { get; set; }

        [DataMember(Name = "operatingSystem", Order = 13)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> OperatingSystem { get; set; }

        [DataMember(Name = "permissions", Order = 14)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> Permissions { get; set; }

        [DataMember(Name = "processorRequirements", Order = 15)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> ProcessorRequirements { get; set; }

        [DataMember(Name = "releaseNotes", Order = 16)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> ReleaseNotes { get; set; }

        [DataMember(Name = "screenshot", Order = 17)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<ImageObject, Uri> Screenshot { get; set; }

        [DataMember(Name = "softwareAddOn", Order = 18)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<SoftwareApplication> SoftwareAddOn { get; set; }

        [DataMember(Name = "softwareHelp", Order = 19)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<CreativeWork> SoftwareHelp { get; set; }

        [DataMember(Name = "softwareRequirements", Order = 20)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> SoftwareRequirements { get; set; }

        [DataMember(Name = "softwareVersion", Order = 21)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<string> SoftwareVersion { get; set; }

        [DataMember(Name = "storageRequirements", Order = 22)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public Either<string, Uri> StorageRequirements { get; set; }

        [DataMember(Name = "supportingData", Order = 23)]
        [JsonConverter(typeof(SchemaJsonConverter))]
        public OneOrMore<DataFeed> SupportingData { get; set; }
    }
}
