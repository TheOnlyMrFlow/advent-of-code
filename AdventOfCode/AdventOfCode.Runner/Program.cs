// See https://aka.ms/new-console-template for more information

using AdventOfCode._2023.Day1;

Console.WriteLine("--------------");
Console.WriteLine("Day1 result:");

var dayOneInput = File.ReadAllText("Inputs/day1.txt");
var result = CalibrationDocument.Parse(dayOneInput).GetCalibrationValue();

Console.WriteLine(result);