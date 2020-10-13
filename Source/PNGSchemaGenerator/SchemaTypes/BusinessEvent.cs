namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class BusinessEvent : Event
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessEvent";
    }
}
