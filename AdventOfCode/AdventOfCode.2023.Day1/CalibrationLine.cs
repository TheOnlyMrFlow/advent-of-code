namespace AdventOfCode._2023.Day1;

public class CalibrationLine(string value)
{
    public string Value { get; set; } = value;

    public int GetCalibrationValue()
    {
        return int.Parse($"{GetFirstDigit()}{GetLastDigit()}");
    }

    private char GetFirstDigit() => Value.FirstOrDefault(char.IsDigit);
    
    private char GetLastDigit() => Value.Reverse().FirstOrDefault(char.IsDigit);
}