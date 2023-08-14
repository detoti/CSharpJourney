using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var meses = new Dictionary<int, string>
        {
            {1, "January"},
            {2, "February"},
            {3, "March"},
            {4, "April"},
            {5, "May"},
            {6, "June"},
            {7, "July"},
            {8, "August"},
            {9, "September"},
            {10, "October"},
            {11, "November"},
            {12, "December"}
        };

        string consulta = Console.ReadLine();
        int mes = int.Parse(consulta);


        if (meses.TryGetValue(mes, out var resultado))
        {
            Console.WriteLine($"{resultado}");
        }
        else
        {
            return;
        }
    }
}

