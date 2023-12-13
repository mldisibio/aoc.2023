namespace aoc._2023.tests;


public class CalibrationReaderTests
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void FirstAndLastDigitComposer_ReturnsCorrectValue(string line, int expected)
    {
        // Arrange
        var composer = CalibrationReader.ComposeCalibration;

        // Act
        int result = composer(line);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SumAllCalibrationValues_ReturnsCorrectSum()
    {
        // Arrange
        var lines = new[] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" };
        var calculator = (IEnumerable<string> allLines) => CalibrationReader.SumAllCalibrationValues(CalibrationReader.ComposeCalibration, allLines);
        // Act
        int total = calculator(lines);

        // Assert
        Assert.Equal(142, total);
    }

    [Theory]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    [InlineData("eighthree", 83)]
    [InlineData("sevenine", 79)]
    public void FirstAndLastDigitComposer_IncludesDigitWords(string line, int expected)
    {
        // Arrange
        var composer = CalibrationReader.ComposeCalibrationIncludingDigitNames;

        // Act
        int result = composer(line);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SumAllCalibrationValuesIncludingDigitNames_ReturnsCorrectSum()
    {
        // Arrange
        var lines = new[] { "two1nine","eightwothree","abcone2threexyz","xtwone3four","4nineeightseven2","zoneight234","7pqrstsixteen" };
        var calculator = (IEnumerable<string> allLines) => CalibrationReader.SumAllCalibrationValues(CalibrationReader.ComposeCalibrationIncludingDigitNames, allLines);
        // Act
        int total = calculator(lines);

        // Assert
        Assert.Equal(281, total);
    }

}
