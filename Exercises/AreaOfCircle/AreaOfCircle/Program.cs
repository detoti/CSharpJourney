using System;

class Program
{
    static void Main()
    {
        double pi = 3.14159;
        string r = Console.ReadLine();
        double rParse = double.Parse(r);
        double result = pi * rParse * rParse;
        Console.WriteLine($"A={result:F4}");
    }
}