namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        DoMath(3, 5);
    }

    public static void DoMath(double x, double y)
    {
        double resultAdd = x + y;
        double resultMult = x * y;
        Console.WriteLine(resultAdd);
        Console.WriteLine(resultMult);
    }
}
