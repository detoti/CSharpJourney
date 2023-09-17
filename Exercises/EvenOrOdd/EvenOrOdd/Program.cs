using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                if (X % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }

                if (X > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}
