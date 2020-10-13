using System;
namespace PNGSchemaGenerator.Utilities
{
    using System.Collections;

    public interface IValues : IEnumerable
    {
        int Count { get; }
    }
}
