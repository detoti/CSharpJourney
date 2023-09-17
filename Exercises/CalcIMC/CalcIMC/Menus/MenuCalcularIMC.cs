using System;
using CalcIMC.Modelos;
using OpenAI_API;

namespace CalcIMC.Menus;

internal class MenuCalcularIMC : Menu
{
    public override void Executar(Dictionary<string, Pessoa> pessoasRegistradas)
    {
        base.Executar(pessoasRegistradas);
        ExibirTituloDaOpcao("Calculando o IMC");
        Console.Write("Digite o nome da pessoa que deseja calcular o IMC: ");
        string nomeDaPessoa = Console.ReadLine()!;
        if (pessoasRegistradas.ContainsKey(nomeDaPessoa))
        {
            Pessoa pessoa = pessoasRegistradas[nomeDaPessoa];
            double peso = pessoa.ObterPeso();
            double altura = pessoa.ObterAltura();

            if (peso < 40.0 || peso > 160.0 || altura < 1.4 || altura > 2.0)
            {
                Console.WriteLine("\nImpossível calcular:");

                if (peso < 40.0 || peso > 160.0)
                {
                    Console.WriteLine("Peso fora dos limites (40kg - 160kg)");
                }

                if (altura < 1.4 || altura > 2.0)
                {
                    Console.WriteLine("Altura fora dos limites (1.4m - 2.0m)");
                }

                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                double imc = peso / (altura * altura);

                Console.WriteLine($"\nO IMC da pessoa {nomeDaPessoa} é de: {imc:F1}");
                Thread.Sleep(2000);
                Console.WriteLine("\nAguarde, informações sobre o IMC estão sendo geradas pelo Chat-GPT");
                string resposta = RespostaDoChatGPT(imc);
                Console.WriteLine($"\n{resposta}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
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

    private string RespostaDoChatGPT(double imc)
    {
        var client = new OpenAIAPI("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");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma informações sobre o IMC {imc:F1} da pessoa em 1 paragrafo. Adote um estilo formal. Não explique o calculo do IMC.");
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        return resposta;
    }
}

