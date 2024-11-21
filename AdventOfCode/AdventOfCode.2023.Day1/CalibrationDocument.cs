namespace AdventOfCode._2023.Day1;

public class CalibrationDocument(CalibrationLine[] calibrationLines)
{
    public CalibrationLine[] CalibrationLines { get; set; } = calibrationLines;

    public static CalibrationDocument Parse(string document)
    {
        var lines = document
            .Split(Environment.NewLine)
            .Select(l => new CalibrationLine(l));

        return new CalibrationDocument(lines.ToArray());
    }

    public int GetCalibrationValue() => CalibrationLines.Sum(cl => cl.GetCalibrationValue());
}