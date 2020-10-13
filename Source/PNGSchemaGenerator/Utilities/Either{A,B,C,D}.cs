namespace PNGSchemaGenerator.Utilities
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public struct Either<T1, T2, T3, T4>
        : IReadOnlyCollection<object>, IEnumerable<object>, IValues
    {
        #region Constructor
        public Either(OneOrMore<T1> value)
        {
            ValueA = value;
            ValueB = default(OneOrMore<T2>);
            ValueC = default(OneOrMore<T3>);
            ValueD = default(OneOrMore<T4>);
            HasValueA = value.Count > 0;
            HasValueB = false;
            HasValueC = false;
            HasValueD = false;
        }

        public Either(OneOrMore<T2> value)
        {
            ValueA = default(OneOrMore<T1>);
            ValueB = value;
            ValueC = default(OneOrMore<T3>);
            ValueD = default(OneOrMore<T4>);
            HasValueA = false;
            HasValueB = value.Count > 0;
            HasValueC = false;
            HasValueD = false;
        }

        public Either(OneOrMore<T3> value)
        {
            ValueA = default(OneOrMore<T1>);
            ValueB = default(OneOrMore<T2>);
            ValueC = value;
            ValueD = default(OneOrMore<T4>);
            HasValueA = false;
            HasValueB = false;
            HasValueC = value.Count > 0;
            HasValueD = false;
        }

        public Either(OneOrMore<T4> value)
        {
            ValueA = default(OneOrMore<T1>);
            ValueB = default(OneOrMore<T2>);
            ValueC = default(OneOrMore<T3>);
            ValueD = value;
            HasValueA = false;
            HasValueB = false;
            HasValueC = false;
            HasValueD = value.Count > 0;
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
            List<T4> itemsD = null;
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
                if (item is T3 item3)
                {
                    if (itemsC == null)
                        itemsC = new List<T3>();
                    itemsC.Add(item3);
                }
                if (item is T4 item4)
                {
                    if (itemsD == null)
                        itemsD = new List<T4>();
                    itemsD.Add(item4);
                }
            }
            HasValueA = itemsA?.Count > 0;
            HasValueB = itemsB?.Count > 0;
            HasValueC = itemsC?.Count > 0;
            HasValueD = itemsD?.Count > 0;
            ValueA = itemsA == null ? default(OneOrMore<T1>) : (OneOrMore<T1>)itemsA;
            ValueB = itemsB == null ? default(OneOrMore<T2>) : (OneOrMore<T2>)itemsB;
            ValueC = itemsC == null ? default(OneOrMore<T3>) : (OneOrMore<T3>)itemsC;
            ValueD = itemsD == null ? default(OneOrMore<T4>) : (OneOrMore<T4>)itemsD;
        }

        #endregion
        public int Count => ValueA.Count + ValueB.Count + ValueC.Count + ValueD.Count;
        public bool HasValue => HasValueA || HasValueB || HasValueC || HasValueD;
        public bool HasValueA { get; }
        public bool HasValueB { get; }
        public bool HasValueC { get; }
        public bool HasValueD { get; }

        public OneOrMore<T1> ValueA { get; }
        public OneOrMore<T2> ValueB { get; }
        public OneOrMore<T3> ValueC { get; }
        public OneOrMore<T4> ValueD { get; }

        public static implicit operator Either<T1, T2, T3, T4>(T1 item) => new Either<T1, T2, T3, T4>(item);
        public static implicit operator Either<T1, T2, T3, T4>(T2 item) => new Either<T1, T2, T3, T4>(item);
        public static implicit operator Either<T1, T2, T3, T4>(T3 item) => new Either<T1, T2, T3, T4>(item);
        public static implicit operator Either<T1, T2, T3, T4>(T4 item) => new Either<T1, T2, T3, T4>(item);
        public static implicit operator Either<T1, T2, T3, T4>(T1[] array) => new Either<T1, T2, T3, T4>(array);
        public static implicit operator Either<T1, T2, T3, T4>(T2[] array) => new Either<T1, T2, T3, T4>(array);
        public static implicit operator Either<T1, T2, T3, T4>(T3[] array) => new Either<T1, T2, T3, T4>(array);
        public static implicit operator Either<T1, T2, T3, T4>(T4[] array) => new Either<T1, T2, T3, T4>(array);
        public static implicit operator Either<T1, T2, T3, T4>(List<T1> list) => new Either<T1, T2, T3, T4>(list);
        public static implicit operator Either<T1, T2, T3, T4>(List<T2> list) => new Either<T1, T2, T3, T4>(list);
        public static implicit operator Either<T1, T2, T3,T4>(List<T3> list) => new Either<T1, T2, T3, T4>(list);
        public static implicit operator Either<T1, T2, T3,T4>(List<T4> list) => new Either<T1, T2, T3, T4>(list);
        public static implicit operator Either<T1, T2, T3, T4>(object[] array) => new Either<T1, T2, T3, T4>(array);
        public static implicit operator Either<T1, T2, T3, T4>(List<object> list) => new Either<T1, T2, T3, T4>(list);
        public static implicit operator T1(Either<T1, T2, T3, T4> values) => values.ValueA.FirstOrDefault();
        public static implicit operator T2(Either<T1, T2, T3, T4> values) => values.ValueB.FirstOrDefault();
        public static implicit operator T3(Either<T1, T2, T3, T4> values) => values.ValueC.FirstOrDefault();
        public static implicit operator T4(Either<T1, T2, T3, T4> values) => values.ValueD.FirstOrDefault();
        public static implicit operator T1[](Either<T1, T2, T3, T4> values) => values.ValueA.ToArray();
        public static implicit operator T2[](Either<T1, T2, T3, T4> values) => values.ValueB.ToArray();
        public static implicit operator T3[](Either<T1, T2, T3, T4> values) => values.ValueC.ToArray();
        public static implicit operator T4[](Either<T1, T2, T3, T4> values) => values.ValueD.ToArray();
        public static implicit operator List<T1>(Either<T1, T2, T3, T4> values) => values.ValueA.ToList();
        public static implicit operator List<T2>(Either<T1, T2, T3, T4> values) => values.ValueB.ToList();
        public static implicit operator List<T3>(Either<T1, T2, T3, T4> values) => values.ValueC.ToList();
        public static implicit operator List<T4>(Either<T1, T2, T3, T4> values) => values.ValueD.ToList();
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
            if (HasValueC)
            {
                foreach (var item in ValueC)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
