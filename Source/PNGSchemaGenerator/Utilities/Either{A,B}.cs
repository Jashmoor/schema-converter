namespace PNGSchemaGenerator.Utilities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct Either<T1, T2>
        : IReadOnlyCollection<object>, IEnumerable<object>, IValues
    {
        #region Constructor
        public Either(OneOrMore<T1> value)
        {
            ValueA = value;
            ValueB = default;
            HasValueA = value.Count > 0;
            HasValueB = false;
        }

        public Either(OneOrMore<T2> value)
        {
            ValueA = default;
            ValueB = value;
            HasValueA = false;
            HasValueB = value.Count > 0;
        }

        public Either(params object[] items)
            : this(items.AsEnumerable())
        {
        }

        public Either(IEnumerable<object> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            List<T1> itemsA = null;
            List<T2> itemsB = null;

            foreach (var item in items)
            {
                if (item is T1 item1)
                {
                    if (itemsA == null)
                        itemsA = new List<T1>();
                    itemsA.Add(item1);
                }
                if (item is T2 item2)
                {
                    if (itemsB == null)
                        itemsB = new List<T2>();
                    itemsB.Add(item2);
                }
            }
            HasValueA = itemsA?.Count > 0;
            HasValueB = itemsB?.Count > 0;
            ValueA = itemsA == null ? default : (OneOrMore<T1>)itemsA;
            ValueB = itemsA == null ? default : (OneOrMore<T2>)itemsB;
        }
        #endregion
        public int Count => ValueA.Count + ValueB.Count;
        public bool HasValue => HasValueA || HasValueB;
        public bool HasValueA { get; }
        public bool HasValueB { get; }
        public OneOrMore<T1> ValueA { get; }
        public OneOrMore<T2> ValueB { get; }

        public static implicit operator Either<T1, T2>(T1 item) => new Either<T1, T2>(item);
        public static implicit operator Either<T1, T2>(T2 item) => new Either<T1, T2>(item);
        public static implicit operator Either<T1, T2>(T1[] array) => new Either<T1, T2>(array);
        public static implicit operator Either<T1, T2>(T2[] array) => new Either<T1, T2>(array);
        public static implicit operator Either<T1, T2>(List<T1> list) => new Either<T1, T2>(list);
        public static implicit operator Either<T1, T2>(List<T2> list) => new Either<T1, T2>(list);
        public static implicit operator Either<T1, T2>(object[] array) => new Either<T1, T2>(array);
        public static implicit operator Either<T1, T2>(List<object> list) => new Either<T1, T2>(list);
        public static implicit operator T1(Either<T1, T2> values) => values.ValueA.FirstOrDefault();
        public static implicit operator T2(Either<T1, T2> values) => values.ValueB.FirstOrDefault();
        public static implicit operator T1[](Either<T1, T2> values) => values.ValueA.ToArray();
        public static implicit operator T2[](Either<T1, T2> values) => values.ValueB.ToArray();
        public static implicit operator List<T1>(Either<T1, T2> values) => values.ValueA.ToList();
        public static implicit operator List<T2>(Either<T1, T2> values) => values.ValueB.ToList();
        public IEnumerator<object> GetEnumerator()
        {
            if (HasValueA)
            {
                foreach (var item in ValueA)
                {
                    yield return item;
                }
            }
            if (HasValueB)
            {
                foreach (var item in ValueB)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
