Musica musica1 = new Musica();
musica1.Nome = "All In Gang";
musica1.Artista = "Cone Crew Diretoria";
musica1.Duracao = 230;
musica1.Disponivel = (true);
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Calma na Alma";
musica2.Artista = "Cone Crew Diretoria";
musica2.Duracao = 317;
musica2.Disponivel = (false);
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();