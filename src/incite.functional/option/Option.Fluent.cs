using static incite.functional.FnConstructs;

namespace incite.functional;

#pragma warning disable CS1591
public static partial class Option
{
    /// <summary>Alternative syntax to return Some <typeparamref name="T"/> or an eagerly evaluated <paramref name="default"/> if None.</summary>
    public static T GetValueOr<T>(this Option<T> src, T @default)
        => src.Match
        (
            None: () => @default,
            Some: t => t
        );

    /// <summary>Alternative syntax to return Some <typeparamref name="T"/> or lazily evaluate <paramref name="factory"/> if None.</summary>
    public static T GetValueOr<T>(this Option<T> src, Func<T> factory)
        => src.Match
        (
            None: factory,
            Some: t => t
        );

    public static Task<T> GetOrElse<T>(this Option<T> opt, Func<Task<T>> fallback)
        => opt.Match
        (
          () => fallback(),
          (t) => Async(t)
        );

    /// <summary>Return <paramref name="left"/> is Some, otherwise <paramref name="right"/>.</summary>
    public static Option<T> IfSomeElse<T>(this Option<T> left, Option<T> right)
        => left.Match
        (
            None: () => right,
            Some: _ => left
        );

    /// <summary>Return <paramref name="left"/> is Some, otherwise invoke <paramref name="right"/>.</summary>
    public static Option<T> IfSomeElse<T>(this Option<T> left, Func<Option<T>> right)
        => left.Match
        (
            None: () => right(),
            Some: _ => left
        );
}
#pragma warning restore CS1591
