﻿namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            int x = Int32.Parse(Console.ReadLine()!);
            int y = Int32.Parse(Console.ReadLine()!);
			Console.WriteLine($"Multiplication: {Multiplication(x, y)}");
            Console.WriteLine("Addition: " + Add(x, y));
        }

        public static int Add(int x, int y)
        {
            return x + y;    
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
