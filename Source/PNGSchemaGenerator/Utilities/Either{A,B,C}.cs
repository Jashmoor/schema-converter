namespace PNGSchemaGenerator.Utilities
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public struct Either<T1, T2, T3>
        : IReadOnlyCollection<object>, IEnumerable<object>, IValues
    {
        #region Constructor
        public Either(OneOrMore<T1> value)
        {
            ValueA = value;
            ValueB = default(OneOrMore<T2>);
            ValueC = default(OneOrMore<T3>);
            HasValueA = value.Count > 0;
            HasValueB = false;
            HasValueC = false;
        }

        public Either(OneOrMore<T2> value)
        {
            ValueA = default(OneOrMore<T1>);
            ValueB = value;
            ValueC = default(OneOrMore<T3>);
            HasValueA = false;
            HasValueB = value.Count > 0;
            HasValueC = false;
        }

        public Either(OneOrMore<T3> value)
        {
            ValueA = default(OneOrMore<T1>);
            ValueB = default(OneOrMore<T2>);
            ValueC = value;
            HasValueA = false;
            HasValueB = false;
            HasValueC = value.Count > 0;
        }

        public Either(params object[] items)
            : this(items.AsEnumerable())
        {
        }

        public Either(IEnumerable<object> items)
        {
            List<T1> itemsA = null;
            List<T2> itemsB = null;
            List<T3> itemsC = null;
            foreach(var item in items)
            {
                if(item is T1 item1)
                {
                    if (itemsA == null)
                        itemsA = new List<T1>();
                    itemsA.Add(item1);
                }
                if(item is T2 item2)
                {
                    if (itemsB == null)
                        itemsB = new List<T2>();
                    itemsB.Add(item2);
                }
                if(item is T3 item3)
                {
                    if (itemsC == null)
                        itemsC = new List<T3>();
                    itemsC.Add(item3);
                }
            }
            HasValueA = itemsA?.Count > 0;
            HasValueB = itemsB?.Count > 0;
            HasValueC = itemsC?.Count > 0;
            ValueA = itemsA == null ? default(OneOrMore<T1>) : (OneOrMore<T1>)itemsA;
            ValueB = itemsB == null ? default(OneOrMore<T2>) : (OneOrMore<T2>)itemsB;
            ValueC = itemsC == null ? default(OneOrMore<T3>) : (OneOrMore<T3>)itemsC;
        }

        #endregion
        public int Count => ValueA.Count + ValueB.Count + ValueC.Count;
        public bool HasValue => HasValueA || HasValueB || HasValueC;
        public bool HasValueA { get; }
        public bool HasValueB { get; }
        public bool HasValueC { get; }

        public OneOrMore<T1> ValueA { get; }
        public OneOrMore<T2> ValueB { get; }
        public OneOrMore<T3> ValueC { get; }

        public static implicit operator Either<T1, T2, T3>(T1 item) => new Either<T1, T2, T3>(item);
        public static implicit operator Either<T1, T2, T3>(T2 item) => new Either<T1, T2, T3>(item);
        public static implicit operator Either<T1, T2, T3>(T3 item) => new Either<T1, T2, T3>(item);
        public static implicit operator Either<T1, T2, T3>(T1[] array) => new Either<T1, T2, T3>(array);
        public static implicit operator Either<T1, T2, T3>(T2[] array) => new Either<T1, T2, T3>(array);
        public static implicit operator Either<T1, T2, T3>(T3[] array) => new Either<T1, T2, T3>(array);
        public static implicit operator Either<T1, T2, T3>(List<T1> list) => new Either<T1, T2, T3>(list);
        public static implicit operator Either<T1, T2, T3>(List<T2> list) => new Either<T1, T2, T3>(list);
        public static implicit operator Either<T1, T2, T3>(List<T3> list) => new Either<T1, T2, T3>(list);
        public static implicit operator Either<T1, T2, T3>(object[] array) => new Either<T1, T2, T3>(array);
        public static implicit operator Either<T1, T2,T3>(List<object> list) => new Either<T1, T2, T3>(list);
        public static implicit operator T1(Either<T1, T2, T3> values) => values.ValueA.FirstOrDefault();
        public static implicit operator T2(Either<T1, T2, T3> values) => values.ValueB.FirstOrDefault();
        public static implicit operator T3(Either<T1, T2, T3> values) => values.ValueC.FirstOrDefault();
        public static implicit operator T1[](Either<T1, T2, T3> values) => values.ValueA.ToArray();
        public static implicit operator T2[](Either<T1, T2, T3> values) => values.ValueB.ToArray();
        public static implicit operator T3[](Either<T1, T2, T3> values) => values.ValueC.ToArray();
        public static implicit operator List<T1>(Either<T1, T2, T3> values) => values.ValueA.ToList();
        public static implicit operator List<T2>(Either<T1, T2, T3> values) => values.ValueB.ToList();
        public static implicit operator List<T3>(Either<T1, T2, T3> values) => values.ValueC.ToList();
        public IEnumerator<object> GetEnumerator()
        {
            if (HasValueA)
            {
                foreach(var item in ValueA)
                {
                    yield return item;
                }
            }
            if (HasValueB)
            {
                foreach(var item in ValueB)
                {
                    yield return item;
                }
            }
            if (HasValueC)
            {
                foreach(var item in ValueC)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
