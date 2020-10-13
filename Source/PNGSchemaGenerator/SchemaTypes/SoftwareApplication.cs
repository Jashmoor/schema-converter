namespace PNGSchemaGenerator.SchemaTypes
{
    using PNGSchemaGenerator.Utilities;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class SoftwareApplication : CreativeWork
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareApplication";

        [DataMember(Name = "applicationCategory", Order = 2)]
        public Either<string, Uri> ApplicationCategory { get; set; }

        [DataMember(Name = "applicationSubCategory", Order = 3)]
        public Either<string, Uri> ApplicationSubCategory { get; set; }

        [DataMember(Name = "applicationSuite", Order = 4)]
        public OneOrMore<string> ApplicationSuite { get; set; }

        [DataMember(Name = "availableOnDevice", Order = 5)]
        public OneOrMore<string> AvailableOnDevice { get; set; }

        [DataMember(Name = "countriesNotSupported", Order = 6)]
        public OneOrMore<string> CountriesNotSupported { get; set; }

        [DataMember(Name = "countriesSupported", Order = 7)]
        public OneOrMore<string> CountriesSupported { get; set; }

        [DataMember(Name = "downloadUrl", Order = 8)]
        public OneOrMore<Uri> DownloadUrl { get; set; }

        [DataMember(Name = "featureList", Order = 9)]
        public Either<string, Uri> FeatureList { get; set; }

        [DataMember(Name = "fileSize", Order = 10)]
        public OneOrMore<string> FileSize { get; set; }

        [DataMember(Name = "installUrl", Order = 11)]
        public OneOrMore<Uri> InstallUrl { get; set; }

        [DataMember(Name = "memoryRequirements", Order = 12)]
        public Either<string, Uri> MemoryRequirements { get; set; }

        [DataMember(Name = "operatingSystem", Order = 13)]
        public OneOrMore<string> OperatingSystem { get; set; }

        [DataMember(Name = "permissions", Order = 14)]
        public OneOrMore<string> Permissions { get; set; }

        [DataMember(Name = "processorRequirements", Order = 15)]
        public OneOrMore<string> ProcessorRequirements { get; set; }

        [DataMember(Name = "releaseNotes", Order = 16)]
        public Either<string, Uri> ReleaseNotes { get; set; }

        [DataMember(Name = "screenshot", Order = 17)]
        public Either<ImageObject, Uri> Screenshot { get; set; }

        [DataMember(Name = "softwareAddOn", Order = 18)]
        public OneOrMore<SoftwareApplication> SoftwareAddOn { get; set; }

        [DataMember(Name = "softwareHelp", Order = 19)]
        public OneOrMore<CreativeWork> SoftwareHelp { get; set; }

        [DataMember(Name = "softwareRequirements", Order = 20)]
        public Either<string, Uri> SoftwareRequirements { get; set; }

        [DataMember(Name = "softwareVersion", Order = 21)]
        public OneOrMore<string> SoftwareVersion { get; set; }

        [DataMember(Name = "storageRequirements", Order = 22)]
        public Either<string, Uri> StorageRequirements { get; set; }

        [DataMember(Name = "supportingData", Order = 23)]
        public OneOrMore<DataFeed> SupportingData { get; set; }
    }
}
