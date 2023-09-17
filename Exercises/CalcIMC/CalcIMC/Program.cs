using CalcIMC.Menus;
using CalcIMC.Modelos;

Dictionary<string, Pessoa> pessoasRegistradas = new();

Dictionary<int, Menu > opcoes = new();
opcoes.Add(1, new MenuRegistrarPessoa());
opcoes.Add(2, new MenuRegistrarInfoPessoa());
opcoes.Add(3, new MenuMostrarPessoasRegistradas());
opcoes.Add(4, new MenuCalcularIMC());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

╔══╦═╗╔═╦═══╗──╔╗───╔═══╦═══╦════╦════╦══╗
╚╣╠╣║╚╝║║╔═╗║──║║───║╔═╗║╔═╗║╔╗╔╗║╔╗╔╗╠╣╠╝
─║║║╔╗╔╗║║─╚╝╔═╝╠══╗║║─╚╣║─║╠╝║║╚╩╝║║╚╝║║
─║║║║║║║║║─╔╗║╔╗║╔╗║║║╔═╣╚═╝║─║║───║║──║║
╔╣╠╣║║║║║╚═╝║║╚╝║╚╝║║╚╩═║╔═╗║─║║───║║─╔╣╠╗
╚══╩╝╚╝╚╩═══╝╚══╩══╝╚═══╩╝─╚╝─╚╝───╚╝─╚══╝

");
    Console.WriteLine("Bem vindo a Calculadora de IMC do Gatti!");
    Console.WriteLine("A única com limites definidos!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma pessoa");
    Console.WriteLine("Digite 2 para registrar as informaçōes da pessoa");
    Console.WriteLine("Digite 3 para exibir a lista de pessoas registradas");
    Console.WriteLine("Digite 4 para calcular o IMC da pessoa");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(pessoasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();