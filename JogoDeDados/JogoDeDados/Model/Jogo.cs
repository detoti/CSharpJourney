using System;
namespace JogoDeDados.Model;

public class Jogo
{
    public static string DefinirVencedor(int soma)
    {
        if (soma == 7 || soma == 11)
            return "Jogador";
        else
            return "Computador";
    }
}

