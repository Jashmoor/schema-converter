namespace PNGSchemaGenerator.Utilities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public struct OneOrMore<T>
        : IReadOnlyCollection<T>, IEnumerable<T>, IValues
    {
        #region Constructor
        public OneOrMore(T item)
        {
            if (item == null)
            {
                Value = default(T);
                Collection = null;
                HasOne = false;
            }
            else
            {
                Value = item;
                Collection = null;
                HasOne = true;
            }
        }

        public OneOrMore(IEnumerable<T> items)
            : this(items == null ? null : items.ToArray())
        {
        }

        public OneOrMore(IEnumerable<object> items)
            : this(items == null ? null : items.Cast<T>().ToArray())
        {
        }

        public OneOrMore(params T[] items)
        {
            Value = default(T);
            Collection = null;
            HasOne = false;

            if (items.Length == 1)
            {
                Value = items.FirstOrDefault();
                HasOne = true;
            }
            if (items.Length > 1)
            {
                Collection = items;
            }
        }
        #endregion
        private readonly T[] Collection;
        private readonly T Value;
        public int Count => Collection?.Length ?? 0;
        public bool HasOne { get; }
        public bool HasMany => Collection?.Length > 1;

        public static implicit operator OneOrMore<T>(T item) => new OneOrMore<T>(item);
        public static implicit operator OneOrMore<T>(T[] array) => new OneOrMore<T>(array);
        public static implicit operator OneOrMore<T>(List<T> list) => new OneOrMore<T>(list);
        public static implicit operator T(OneOrMore<T> item) => item.Value == null ? default(T) : item.Value;
        public static implicit operator T[](OneOrMore<T> item) => item.ToArray();
        public static implicit operator List<T>(OneOrMore<T> item) => item.ToList();

        public IEnumerator<T> GetEnumerator()
        {
            if (Collection is object)
            {
                for (var i = 0; i < Collection.Length; i++)
                {
                    yield return Collection[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T[] ToArray()
        {
            if (HasOne)
                return new[] { Collection[0] };
            if (HasMany)
            {
                T[] result = new T[Collection.Length];
                Array.Copy(Collection, 0, result, 0, Collection.Length);
                return result;
            }
            return Array.Empty<T>();
        }
    }
}
