using System;
namespace Jogo100Dados.View;

public class Tela
{
    //public void exibirFace(int valor)
    //{
    //    Console.WriteLine($"O dado caiu com a face: {valor}");
    //}
    public void exibir(int soma)
    {
        Console.WriteLine($"A soma das faces é: {soma}");
    }

    public void exibir(string vencedor)
    {
        Console.WriteLine($"O vencedor é: {vencedor}");
    }

    public void exibirBotaoJogar()
    {
        Console.WriteLine("Pressione Enter para jogar.");
    }
    public void exibirLogo()
    {
        Console.WriteLine(@"


░░█ █▀█ █▀▀ █▀█ █▀▄ █▀▀ █▀▄ ▄▀█ █▀▄ █▀█ █▀
█▄█ █▄█ █▄█ █▄█ █▄▀ ██▄ █▄▀ █▀█ █▄▀ █▄█ ▄█

");
        Console.WriteLine("Bem vindo ao Jogo de Dados!");
        Console.WriteLine("100 dados serão lançados!");
        Console.WriteLine("Você precisa que a soma dos 100 dados seja 255 ou 450 para vencer!");
    }
}

