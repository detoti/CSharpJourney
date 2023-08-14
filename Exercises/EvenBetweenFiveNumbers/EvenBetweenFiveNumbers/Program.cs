using System;

class Program
{
    static void Main()
    {
        int evenCount = 0;


        for (double i = 0; i < 5; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                evenCount++;
            }

        }
        Console.WriteLine($"{evenCount} valores pares");
    }
}