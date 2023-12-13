using static incite.functional.FnConstructs;
using Unit = System.ValueTuple;

namespace incite.functional;
#pragma warning disable CS1591

public static partial class Adapters
{
    public static Func<T> ToNullary<T>(this Func<Unit, T> fn)
        => () => fn(Unit());

    /// <summary>Return a function that yields the <paramref name="consumer"/> <typeparamref name="TResult"/> from the <paramref name="producer"/> <typeparamref name="T1"/>.</summary>
    public static Func<T1, TResult> ReducedFrom<T1, T2, TResult>(this Func<T2, TResult> consumer, Func<T1, T2> producer)
       => t1 => consumer(producer(t1));

    /// <summary>Return a function that yields the <paramref name="consumer"/> <typeparamref name="TResult"/> from the <paramref name="producer"/> <typeparamref name="T1"/>.</summary>
    public static Func<T1, TResult> Map<T1, T2, TResult>(this Func<T1, T2> producer, Func<T2, TResult> consumer)
       => (t1) => consumer(producer(t1));

    /// <summary>Return a function that yields the <paramref name="consumer"/> <typeparamref name="TResult"/> from the <paramref name="producer"/> <typeparamref name="T1"/> and <typeparamref name="T2"/>.</summary>
    public static Func<T1, T2, TResult> Map<T1, T2, T3, TResult>(this Func<T1, T2, T3> producer, Func<T3, TResult> consumer)
       => (t1, t2) => consumer(producer(t1, t2));

    public static Func<T, bool> Negate<T>(this Func<T, bool> predicate) => t => !predicate(t);

}
#pragma warning restore CS1591