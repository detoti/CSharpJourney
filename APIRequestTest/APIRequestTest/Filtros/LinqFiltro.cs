using APIRequestTest.Modelos;

namespace APIRequestTest.Filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas pelo gênero musical: {genero}");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach ( var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"Musicas de {ano}");
        foreach ( var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals($"{tonalidade}")).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas pela tonalidade: {tonalidade} ");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}

