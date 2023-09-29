using System;
using JogoDeDados.Model;
using JogoDeDados.View;

namespace JogoDeDados.Controller;

public class Aplicacao
{
    private Tela tela;
    private Dado dado1;
    private Dado dado2;
    private Calculadora calculadora;

    public Aplicacao()
    {
        tela = new Tela();
        dado1 = new Dado();
        dado2 = new Dado();
        calculadora = new Calculadora();
    }

    public void Jogar()
    {
        while (true)
        {
            tela.ExibirLogo();
            tela.ExibirBotaoJogar();
            Console.ReadLine();

            dado1.LancarDado();
            dado2.LancarDado();

            int soma = calculadora.CalcularSoma(dado1.GetFace(), dado2.GetFace());
            tela.ExibirFace(dado1.GetFace());
            tela.ExibirFace(dado2.GetFace());
            tela.ExibirSoma(soma);

            string vencedor = Jogo.DefinirVencedor(soma);
            tela.ExibirVencedor(vencedor);


        }
    }
}

