using System.Text.Json;
using APIRequestTest.Modelos;
using APIRequestTest.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[2].ExibirDetalhesDaMusica();
        //LinqFiltro.FiltrarTodosOsGeneros(musicas);
        //LinqOrdenacao.ExibirArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFiltro.FiltrarMusicasArtista(musicas, "Post Malone");
        //LinqFiltro.FiltrarMusicasAno(musicas, 2012);
        LinqFiltro.FiltrarMusicasPorTonalidade(musicas, "C#");

        //var musicasPreferidasAndre = new MusicasPreferidas("Andre");
        //musicasPreferidasAndre.AdicionarMusicasFavoritas(musicas[1998]);
        //musicasPreferidasAndre.AdicionarMusicasFavoritas(musicas[998]);
        //musicasPreferidasAndre.AdicionarMusicasFavoritas(musicas[98]);
        //musicasPreferidasAndre.AdicionarMusicasFavoritas(musicas[8]);
        //musicasPreferidasAndre.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasAndre.ExibirMusicasFavoritas();

        //var musicasPreferidasLarissa = new MusicasPreferidas("Larissa");
        //musicasPreferidasLarissa.AdicionarMusicasFavoritas(musicas[1813]);
        //musicasPreferidasLarissa.AdicionarMusicasFavoritas(musicas[181]);
        //musicasPreferidasLarissa.AdicionarMusicasFavoritas(musicas[81]);
        //musicasPreferidasLarissa.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasLarissa.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasLarissa.ExibirMusicasFavoritas();
        //musicasPreferidasLarissa.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houston temos um problema: {ex.Message} ");
    }
}
