using System;

class Program
{
    static void Main()
    {
        int positiveCount = 0;

        for (double i = 0; i < 6; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                positiveCount++;
            }
        }
        Console.WriteLine($"{positiveCount} valores positivos");
    }
}