// calculator basics

using System.IO.Pipelines;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // method overloading

    public static double Add(double a, double b)
    {
        return a + b;
    }

    // DivideByZeroException

    public static double Divide(int a, int b)
    // double division by zero does not throw an error! (x.x/0 = infinity)
    {
        try
        {
            double result = a / b;
            // to get a mathematically correct double result, "a" must be cast to double:
            // ---> double result = (double)a / b;
            // note: the catch block will never be triggered here because dividing a double by zero does not throw an exception; it simply returns Infinity!
            // the catch only has an effect for integer division (int / int)
            return result;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return double.NaN;
        }
    }
}