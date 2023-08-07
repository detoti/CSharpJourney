using System;

class Program
{
    static void Main()
    {
        string empNum = Console.ReadLine();
        string hours = Console.ReadLine();
        double intHours = double.Parse(hours);
        string value = Console.ReadLine();
        double hrValue = double.Parse(value);

        double salary = intHours * hrValue;

        Console.WriteLine($"NUMBER = {empNum}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");
    }
}