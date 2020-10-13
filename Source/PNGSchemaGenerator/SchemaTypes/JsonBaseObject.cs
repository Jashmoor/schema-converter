namespace PNGSchemaGenerator.SchemaTypes
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class JsonBaseObject
    {
        [DataMember(Name = "@context", Order = 0)]
        public virtual JsonBaseContext Context { get; internal set; } = new JsonBaseContext();

        [DataMember(Name = "@type", Order = 1)]
        public virtual string Type { get; }

        [DataMember(Name = "@id", Order = 2)]
        public virtual Uri Id { get; set; }
    }
}
