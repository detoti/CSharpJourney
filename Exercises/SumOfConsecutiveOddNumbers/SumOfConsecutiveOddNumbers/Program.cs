using System;

class Program
{
    static void Main(string[] args)
    {

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        if ( firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        int oddSum = 0;

        for (int num = firstNumber + 1; num < secondNumber; num++)
        {
            if (num % 2 != 0)
            {
                oddSum += num;
            }    
        }

        Console.WriteLine(oddSum);

    }
}