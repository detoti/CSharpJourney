internal class Program
{
    private static void Main(string[] args)
    {
        //Banda cone = new Banda("Cone Crew Diretoria");

        //Album albumDaCone = new Album("Bonde da Madrugada pt.1");

        //Musica musica1 = new Musica(cone, "To de Volta no Twist")
        //{
        //    Duracao = 226,
        //    Disponivel = true
        //};

        //Musica musica2 = new Musica(cone, "Chefe de Quadrilha")
        //{
        //    Duracao = 278,
        //    Disponivel = false,
        //};

        //Musica musica3 = new Musica(cone, "Pra Minha Mãe")
        //{
        //    Duracao = 332,
        //    Disponivel = true,
        //};


        //albumDaCone.AdicionarMusica(musica1);
        //albumDaCone.AdicionarMusica(musica2);
        //albumDaCone.AdicionarMusica(musica3);
        //cone.AdicionarAlbum(albumDaCone);

        //musica1.ExibirFichaTecnica();
        //musica2.ExibirFichaTecnica();
        //musica3.ExibirFichaTecnica();
        //albumDaCone.ExibirMusicasAlbum();
        //cone.ExibirDiscografia();

        Episodio ep1 = new(1, "Cone Crew", 45);
        ep1.AdicionarConvidado("Rany Money");
        ep1.AdicionarConvidado("Batoré");

        Episodio ep2 = new(2, "N.W.E", 120);
        ep2.AdicionarConvidado("Ice Cube");
        ep2.AdicionarConvidado("Dr. Dre");

        Episodio ep3 = new(3, "Eminem and 50 Cent", 240);
        ep3.AdicionarConvidado("Eminem");
        ep3.AdicionarConvidado("50 Cent");

        Podcast podcast = new("Sound System", "André Toti");
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.AdicionarEpisodio(ep3);
        podcast.ExibirDetalhes();
    }
}