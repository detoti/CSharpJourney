using System;

class Program
{
    static void Main(string[] args)
    {
        int visitantes = int.Parse(Console.ReadLine());

            int visitantes2link = visitantes + visitantes;
            int visitantes1link = visitantes2link + visitantes2link;

            Console.WriteLine(visitantes1link);
        
    }
}