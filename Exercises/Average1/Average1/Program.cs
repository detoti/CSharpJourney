using System;

class Program
{
    static void Main()
    {
        string n1 = Console.ReadLine();
        double nota1 = double.Parse(n1);
        string n2 = Console.ReadLine();
        double nota2 = double.Parse(n2);
        double media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;
        Console.WriteLine($"MEDIA = {media:F5}");
    }
}