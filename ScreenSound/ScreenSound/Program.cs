// ScreenSound - Andre Toti
string mensagemDeBoasVindas = "Bem vindo ao ScreenSound";

//List<string> listaDasBandas = new List<string> { "Cone Crew Diretoria", "N.W.A", "D12"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Cone Crew Diretoria", new List<int> { 10, 8, 9});
bandasRegistradas.Add("N.W.A", new List<int>());


void ExibirLogo()
{
Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opçåo: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
            break;
        case 5:
            Console.WriteLine("Tchau tchau :) ");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro da Banda");
    Console.Write("Digite o nome da banda para registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo as bandas registradas"); ;
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");

}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliando Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Aperte qualquer tecla para voltar.");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Media de Notas da Banda");
    Console.Write("Digite o nome da banda que deseja saber a media: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A media de notas para a banda {nomeDaBanda} é de {notasDaBanda.Average()}.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Aperte qualquer tecla para voltar.");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();