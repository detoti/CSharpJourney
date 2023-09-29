using System;
namespace Jogo100Dados.Model;

public class Mesa
{
    private List<Dado> dados = new List<Dado>();

    public void AdicionarDado(Dado dado)
    {
        dados.Add(dado);
    }

    public List<int> LancarDados(int numLancamentos)
    {
        List<int> resultados = new List<int>();
        foreach (Dado dado in dados)
        {
            int resultadoLancamento = 0;
            for (int i = 0; i < numLancamentos; i++)
            {
                dado.LancarDado();
                resultadoLancamento += dado.GetFace();
            }
            resultados.Add(resultadoLancamento);
        }
        return resultados;
    }
}

