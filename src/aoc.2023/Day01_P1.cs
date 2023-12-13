namespace aoc._2023;

public class Day01_P1
{
    const string inputFile = @"C:\Users\micha\source\github.mldisibio\aoc.2023\src\aoc.2023\inputs\d01_p1.txt";

    public static int Run()
    {
        var lines = File.ReadLines(inputFile).Where(line => !string.IsNullOrWhiteSpace(line));
        var calculator = (IEnumerable<string> allLines) => CalibrationReader.SumAllCalibrationValues(CalibrationReader.ComposeCalibration, allLines);
        int total = calculator(lines);
        return total;
    }
}

public class Day01_P2
{
    const string inputFile = @"C:\Users\micha\source\github.mldisibio\aoc.2023\src\aoc.2023\inputs\d01_p1.txt";
    const string outputFile = @"C:\Users\micha\source\github.mldisibio\aoc.2023\src\aoc.2023\inputs\d01_p2.txt";

    public static int Run()
    {
        var lines = File.ReadLines(inputFile).Where(line => !string.IsNullOrWhiteSpace(line));
        var calculator = (IEnumerable<string> allLines) => CalibrationReader.SumAllCalibrationValues(CalibrationReader.ComposeCalibrationIncludingDigitNames, allLines);
        int total = calculator(lines);
        return total;
    }

    public static void View()
    {
        File.Create(outputFile).Close();
        var composer = CalibrationReader.ComposeCalibrationIncludingDigitNames;
        var lines = File.ReadLines(inputFile).Where(line => !string.IsNullOrWhiteSpace(line));
        File.AppendAllLines(outputFile, lines.Select(t => $"{composer(t)} <= {t}"));
        //File.AppendAllLines(outputFile, lines.Select(t => $"{composer(t)}"));
    }
}
