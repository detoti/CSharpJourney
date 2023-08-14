using System;

class Program
{
    static void Main()
    {
        int evenCount = 0;
        int oddCount = 0;
        int positiveCount = 0;
        int negativeCount = 0;


        for (double i = 0; i < 5; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }

        }
        Console.WriteLine($"{evenCount} valor(es) par(es)");
        Console.WriteLine($"{oddCount} valor(es) impar(es)");
        Console.WriteLine($"{positiveCount} valor(es) positivo(s)");
        Console.WriteLine($"{negativeCount} valor(es) negativo(s)");
    }
}