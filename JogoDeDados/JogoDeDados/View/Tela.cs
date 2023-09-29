using System;
namespace JogoDeDados.View;

public class Tela
{
	public void ExibirFace(int valor)
	{
		Console.WriteLine($"O dado caiu com a face: {valor}");
    }
    public void ExibirSoma(int soma)
    {
        Console.WriteLine($"A soma das faces é: {soma}");
    }

    public void ExibirVencedor(string vencedor)
    {
        Console.WriteLine($"O vencedor é: {vencedor}");
    }

    public void ExibirBotaoJogar()
    {
        Console.WriteLine("Pressione Enter para jogar.");
    }
    public void ExibirLogo()
    {
            Console.WriteLine(@"


░░█ █▀█ █▀▀ █▀█ █▀▄ █▀▀ █▀▄ ▄▀█ █▀▄ █▀█ █▀
█▄█ █▄█ █▄█ █▄█ █▄▀ ██▄ █▄▀ █▀█ █▄▀ █▄█ ▄█

");
            Console.WriteLine("Bem vindo ao Jogo de Dados!");
            Console.WriteLine("Dois dados serão lançados!");
            Console.WriteLine("Você precisa que a soma dos dois lados dele seja 7 ou 11 para vencer!");
    }
}

