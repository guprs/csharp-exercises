// default and named parameters

public class Stats
{
    public static double Average(double a, double b, double c = 0)
    {
        double averageResult = (a + b + c) / 3; // there is a "developer way" to do it?
        return (double)averageResult;
    }
}