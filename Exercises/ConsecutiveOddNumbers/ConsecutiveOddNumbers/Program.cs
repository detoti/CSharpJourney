using System;

class Program
{
    static void Main()
    {

        int start = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i =  start + 1; counter < 6; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                counter++;
            }
        }

    }
}