using System.Text.RegularExpressions;

namespace aoc._2023;

public delegate int FirstAndLastDigitComposer(string line);

public delegate int CalibrationSumCalculator(FirstAndLastDigitComposer composer, IEnumerable<string> lines);

public static class CalibrationReader
{
    readonly static Regex MatchDigits = new Regex(@"(\d)", RegexOptions.Compiled);

    public static FirstAndLastDigitComposer ComposeCalibration => (string line)
        =>
        {
            // write a regex to match the first and last digit
            // and return a tuple of the two digits;
            // if there is only one digit, return a tuple of the digit and itself
            char[] digits = MatchDigits.Matches(line).Select(m => m.Value[0]).ToArray();
            return int.Parse($"{digits[0]}{digits[^1]}");
        };

   public static CalibrationSumCalculator SumAllCalibrationValues
        => (FirstAndLastDigitComposer composer, IEnumerable<string> lines)
        =>
        {
            return lines.Select(line => composer(line)).Sum();
        };
}
