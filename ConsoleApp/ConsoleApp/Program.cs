namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        DoMath(3, 5);
    }

    public static void DoMath(double x, double y)
    {
        double result = x * y;
        Console.WriteLine(result);
    }
}
