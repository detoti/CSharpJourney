using System;
namespace Jogo100Dados.Model;

public class Calculadora
{
    public int CalcularSoma(List<int> valores)
    {
        int soma = 0;
        foreach (int valor in valores)
        {
            soma += valor;
        }
        return soma;
    }
}

