using Utils;

// calculator basics

using System.Net.NetworkInformation;

Console.WriteLine(Calculator.Add(7, 3)); // 10
Console.WriteLine(Calculator.Multiply(5, 9)); // 45

// division

Console.WriteLine(Calculator.Divide(9, 3)); // 3
Console.WriteLine(Calculator.Divide(7, 0)); // DivideByZeroException if (int)a / Infinity if (double)a
Console.WriteLine(Calculator.Divide(5, 2)); // 2 if (int)a / 2.5 if (double)a --> In C#, dividing two integers is always truncated before any conversion. After the integer division is performed, the truncated result (int) is converted to double and stored in result. So result would be 2, not 2.5.

// default and named parameters

Console.WriteLine(Stats.Average(31.1, 47.7, 59.9)); // 46,23333333333334

// formatter with multiple overloads

Console.WriteLine(Formatter.FormatNumber(7));
Console.WriteLine(Formatter.FormatDouble(9));
Console.WriteLine(Formatter.FormatDouble(11.3));
Console.WriteLine(Formatter.FormatMessage("hello ", 3));
Console.WriteLine(Formatter.FormatMessage("hello from default"));