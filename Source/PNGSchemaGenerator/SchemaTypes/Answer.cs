﻿namespace PNGSchemaGenerator.SchemaTypes
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Answer : Comment
    {
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Answer";
    }
}
