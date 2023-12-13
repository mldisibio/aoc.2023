namespace incite.functional;

#pragma warning disable CS1591

public static partial class FnConstructs
{
    public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> fn)
        => t1 => t2 => fn(t1, t2);

    public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> fn)
        => t1 => t2 => t3 => fn(t1, t2, t3);

    public static Func<T1, Func<T2, T3, TResult>> CurryFirst<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> fn)
        => t1 => (t2, t3) => fn(t1, t2, t3);

    public static Func<T1, Func<T2, T3, T4, TResult>> CurryFirst<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> fn)
        => t1 => (t2, t3, t4) => fn(t1, t2, t3, t4);

    public static Func<T1, Func<T2, T3, T4, T5, TResult>> CurryFirst<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> fn)
        => t1 => (t2, t3, t4, t5) => fn(t1, t2, t3, t4, t5);

    public static Func<T1, Func<T2, T3, T4, T5, T6, TResult>> CurryFirst<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> fn)
        => t1 => (t2, t3, t4, t5, t6) => fn(t1, t2, t3, t4, t5, t6);

    public static Func<T1, Func<T2, T3, T4, T5, T6, T7, TResult>> CurryFirst<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> fn)
        => t1 => (t2, t3, t4, t5, t6, t7) => fn(t1, t2, t3, t4, t5, t6, t7);

    public static Func<T1, Func<T2, T3, T4, T5, T6, T7, T8, TResult>> CurryFirst<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fn)
        => t1 => (t2, t3, t4, t5, t6, t7, t8) => fn(t1, t2, t3, t4, t5, t6, t7, t8);

    public static Func<T1, Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>> CurryFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fn)
        => t1 => (t2, t3, t4, t5, t6, t7, t8, t9) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9);
}
#pragma warning restore CS1591