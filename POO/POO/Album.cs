class Album
{
	private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

	public int DuracaoTotal => musicas.Sum(m => m.Duracao);

	public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ExibirMusicasAlbum()
	{
		Console.WriteLine($"Lista de Musicas do album {Nome}: \n");
		foreach (var musica in musicas)
		{
            Console.WriteLine($"Musica: {musica.Nome}");

        }
		Console.WriteLine($"\nPara ouvir o album inteiro voce precisa de {DuracaoTotal} segundos.");
    }
}
	
