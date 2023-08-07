using System;

class Program
{
    static void Main()
    {
        string n1 = Console.ReadLine();
        int n1int = int.Parse(n1);
        string n2 = Console.ReadLine();
        int n2int = int.Parse(n2);
        int result = n1int + n2int;
        Console.WriteLine($"SOMA = {result}");
    }
}