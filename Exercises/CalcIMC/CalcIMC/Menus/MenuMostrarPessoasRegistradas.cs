using System;
using CalcIMC.Modelos;

namespace CalcIMC.Menus;

internal class MenuMostrarPessoasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Pessoa> pessoasRegistradas)
    {
        base.Executar(pessoasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as pessoas registradas na aplicação");

        foreach (string pessoa in pessoasRegistradas.Keys)
        {
            Console.WriteLine($"Pessoa: {pessoa}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}

