using System;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] list = line.Split();

        int num1 = int.Parse(list[0]);
        int num2 = int.Parse(list[1]);
        int num3 = int.Parse(list[2]);

        int[] sortedArray = { num1, num2, num3 };
        Array.Sort(sortedArray);

        Console.WriteLine($"{sortedArray[0]}\n{sortedArray[1]}\n{sortedArray[2]}");
        Console.WriteLine();
        Console.WriteLine($"{num1}\n{num2}\n{num3}");
    }
}

