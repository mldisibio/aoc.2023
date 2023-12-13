using System.Text.RegularExpressions;

namespace aoc._2023;

public delegate int FirstAndLastDigitComposer(string line);

public delegate int CalibrationSumCalculator(FirstAndLastDigitComposer composer, IEnumerable<string> lines);

public static class CalibrationReader
{
    readonly static Regex MatchDigits = new Regex(@"(\d)", RegexOptions.Compiled);
    //a Regex that matches any digit and also the string "one", "two", "three", etc.
    readonly static Regex MatchDigitOrDigitNames = new Regex(@"(?=(\d|one|two|three|four|five|six|seven|eight|nine))", RegexOptions.Compiled);

    public static FirstAndLastDigitComposer ComposeCalibration => (string line)
        =>
        {
            // using the regex, extract the first and last digit
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

    public static FirstAndLastDigitComposer ComposeCalibrationIncludingDigitNames => (string line)
        =>
        {
            // using the regex, extract the first and last digit
            // and return a tuple of the two digits;
            // if there is only one digit, return a tuple of the digit and itself
            int[] digits = MatchDigitOrDigitNames.Matches(line)
                                                 .Select(MatchToInt)
                                                 .ToArray();
            return int.Parse($"{digits[0]}{digits[^1]}");

            int MatchToInt(Match m)
            {
                string value = m.Groups[1].Value;
                return value switch
                {
                    "one" => 1,
                    "two" => 2,
                    "three" => 3,
                    "four" => 4,
                    "five" => 5,
                    "six" => 6,
                    "seven" => 7,
                    "eight" => 8,
                    "nine" => 9,
                    _ => int.Parse($"{value[0]}")
                };
            }
        };
}
