namespace Utils;

// formatter with multiple overloads

public class Formatter
{
    public static string FormatNumber(int n)
    {
        int intNum = n;
        string inputNumber = intNum.ToString();
        return inputNumber;
    }

    public static string FormatDouble(double d)
    {
        double dNum = d;
        string inputDouble = dNum.ToString("F2"); // 2 decimal positions
        return inputDouble;
    }

    public static string FormatMessage(string text, int repeat = 1)
    {
        string message = text;
        int repeatTimes = repeat;
        string messageRepeat = String.Concat(Enumerable.Repeat(message, repeatTimes));
        return messageRepeat;
    }
}