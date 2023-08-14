using System;

class Program
{
    static void Main()
    {

        int limit = int.Parse(Console.ReadLine());


        if (limit < 1 || limit > 1000)
        {
            return;
        }

        for (int i = 1; i <= limit; i += 2)
        {
            Console.WriteLine(i);
        }

    }
}