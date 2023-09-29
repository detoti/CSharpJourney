using System;
namespace Jogo100Dados.Model;

public class Jogo
{
    public static string DefinirVencedor(int soma)
    {
        if (soma == 255 || soma == 450)
            return "Jogador";
        else
            return "Computador";
    }
}

