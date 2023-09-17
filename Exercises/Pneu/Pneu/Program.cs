using System;

class Program
{
    static void Main(string[] args)
    {
        int pressaoAtual = int.Parse(Console.ReadLine());
        int pressaoDesejada = int.Parse(Console.ReadLine());

        int variacaoPressao = pressaoAtual - pressaoDesejada;

        Console.WriteLine(variacaoPressao);
    }
}