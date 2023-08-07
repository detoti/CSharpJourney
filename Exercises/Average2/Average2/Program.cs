using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        double notaA = double.Parse(a);
        string b = Console.ReadLine();
        double notaB = double.Parse(b);
        string c = Console.ReadLine();
        double notaC = double.Parse(c);

        double media = ((notaA * 2) + (notaB * 3) + (notaC * 5)) / 10;
        Console.WriteLine($"MEDIA = {media:F1}");
    }
}