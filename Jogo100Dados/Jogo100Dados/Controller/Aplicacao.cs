using System;
using Jogo100Dados.Model;
using Jogo100Dados.View;


namespace Jogo100Dados.Controller;

public class Aplicacao
{
    private Tela tela;
    private List<Dado> dados;
    private Calculadora calculadora;

    public Aplicacao(int numeroDados)
    {
        tela = new Tela();
        dados = new List<Dado>();
        for (int i = 0; i < numeroDados; i++)
        {
            dados.Add(new Dado());
        }
        calculadora = new Calculadora();
    }

    public void Jogar()
    {
        int rodadasJogadas = 0;
        bool continuarJogando = true;

        while (continuarJogando)
        {
            tela.exibirLogo();
            tela.exibirBotaoJogar();
            Console.ReadLine();

            int soma = 0;

            foreach (Dado dado in dados)
            {
                dado.LancarDado();
                soma += dado.GetFace();
                //tela.exibirFace(dado.GetFace());
            }

            tela.exibir(soma);

            string vencedor = Jogo.DefinirVencedor(soma);
            tela.exibir(vencedor);

            rodadasJogadas++;

            Console.WriteLine("Deseja continuar jogando? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
            {
                continuarJogando = false;
            }
        }

        Console.WriteLine($"Você jogou {rodadasJogadas} rodadas. Obrigado por jogar!");
    }
}

