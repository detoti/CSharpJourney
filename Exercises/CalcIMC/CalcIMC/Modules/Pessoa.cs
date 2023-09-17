namespace CalcIMC.Modelos;

class Pessoa
{
    private double peso = 0.0;
    private double altura = 0.0;

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarPeso(double novoPeso)
    {
        peso = novoPeso;
    }

    public void AdicionarAltura(double novaAltura)
    {
        altura = novaAltura;
    }

    public double ObterPeso()
    {
        return peso;
    }

    public double ObterAltura()
    {
        return altura;
    }
}


