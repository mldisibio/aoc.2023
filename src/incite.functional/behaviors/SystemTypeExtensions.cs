using static incite.functional.FnConstructs;

namespace incite.functional;
#pragma warning disable CS1591

public static class FnSystem
{
    public static class DateTime
    {
        public static Option<System.DateTime> Maybe(string s) => System.DateTime.TryParse(s, out System.DateTime result) ? Some(result) : None;
    }

    public static class Decimal
    {
        public static Option<decimal> Maybe(string s) => decimal.TryParse(s, out decimal result) ? Some(result) : None;
    }

    public static class Double
    {
        public static Option<double> Maybe(string s) => double.TryParse(s, out double result) ? Some(result) : None;

        public static bool IsOdd(decimal i) => i % 2 == 1;

        public static bool IsEven(decimal i) => i % 2 == 0;

        public static readonly Func<decimal, string> Stringify = d => d.ToString();
    }

    public static class Enum
    {
        public static Option<TEnum> Maybe<TEnum>(string s, bool ignoreCase = false) where TEnum : struct
            => System.Enum.TryParse(s, ignoreCase: ignoreCase, out TEnum t) ? Some(t) : None;
    }

    public static class Int32
    {
        public static Option<int> Maybe(string s) => int.TryParse(s, out int result) ? Some(result) : None;

        public static readonly Func<int, string> Stringify = i => i.ToString();
    }

    public static class Int64
    {
        public static Option<long> Maybe(string s) => long.TryParse(s, out long result) ? Some(result) : None;

        public static readonly Func<long, string> Stringify = n => n.ToString();
    }

    public static Option<T> Maybe<T>(this Nullable<T> src) where T : struct => src.HasValue ? Some(src.Value) : None;

    public static Option<V> Maybe<K, V>(this IDictionary<K, V> dictionary, K key) => dictionary.TryGetValue(key, out V? value) ? Some(value) : None;
}

public static class FnString
{
    /// <summary><see cref="String.Trim()"/> as a delegate.</summary>
    public static readonly Func<string, string> Trim = s => s.Trim();
    /// <summary><see cref="String.ToLower()"/> as a delegate.</summary>
    public static readonly Func<string, string> ToLower = s => s.ToLower();
    /// <summary><see cref="String.ToUpper()"/> as a delegate.</summary>
    public static readonly Func<string, string> ToUpper = s => s.ToUpper();
}
#pragma warning restore CS1591