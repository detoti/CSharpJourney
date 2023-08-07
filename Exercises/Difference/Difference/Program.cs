using System;

class Program
{
    static void Main()
    {
        string n1 = Console.ReadLine();
        int num1 = int.Parse(n1);
        string n2 = Console.ReadLine();
        int num2 = int.Parse(n2);
        string n3 = Console.ReadLine();
        int num3 = int.Parse(n3);
        string n4 = Console.ReadLine();
        int num4 = int.Parse(n4);

        double diferenca = (num1 * num2) - (num3 * num4);
        Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}