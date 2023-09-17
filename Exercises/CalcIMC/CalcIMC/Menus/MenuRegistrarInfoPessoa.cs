using System;
using CalcIMC.Modelos;

namespace CalcIMC.Menus;

internal class MenuRegistrarInfoPessoa : Menu
{
    public override void Executar(Dictionary<string, Pessoa> pessoasRegistradas)
    {
        base.Executar(pessoasRegistradas);
        ExibirTituloDaOpcao("Registrar dados da Pessoa");
        Console.Write("Digite o nome da pessoa que deseja registrar os dados: ");
        string nomeDaPessoa = Console.ReadLine()!;
        if (pessoasRegistradas.ContainsKey(nomeDaPessoa))
        {
            Pessoa nome = pessoasRegistradas[nomeDaPessoa];
            Console.Write($"Qual o peso em kg da pessoa {nomeDaPessoa}: ");
            double peso = double.Parse(Console.ReadLine()!);
            nome.AdicionarPeso(peso);
            Console.Write($"Qual a altura em m da pessoa {nomeDaPessoa}: ");
            double altura = double.Parse(Console.ReadLine()!);
            nome.AdicionarAltura(altura);
            Console.WriteLine($"\nA pessoa {nomeDaPessoa} teve o peso de {peso}kg e altura de {altura}m registrado.");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA pessoa {nomeDaPessoa} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

