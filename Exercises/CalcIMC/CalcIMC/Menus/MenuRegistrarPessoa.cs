using System;
using CalcIMC.Modelos;

namespace CalcIMC.Menus;

internal class MenuRegistrarPessoa : Menu
{
    public override void Executar(Dictionary<string, Pessoa> pessoasRegistradas)
    {
        base.Executar(pessoasRegistradas);
        ExibirTituloDaOpcao("Registro de pessoas");
        Console.Write("Digite o nome da pessoa que deseja registrar: ");
        string nomeDaPessoa = Console.ReadLine()!;
        Pessoa nome = new Pessoa(nomeDaPessoa);
        pessoasRegistradas.Add(nomeDaPessoa, nome);
        Console.WriteLine($"A pessoa {nomeDaPessoa} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}

