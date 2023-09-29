using Jogo100Dados.Controller;

class Program
{
    static void Main(string[] args)
    {
        int numeroDados = 100;
        Aplicacao aplicacao = new Aplicacao(numeroDados);
        aplicacao.Jogar();
    }
}

