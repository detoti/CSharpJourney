using System;
using CalcIMC.Modelos;

namespace CalcIMC.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Pessoa> pessoasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}

