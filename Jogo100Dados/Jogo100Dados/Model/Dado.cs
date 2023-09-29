using System;
namespace Jogo100Dados.Model;

public class Dado
{

    private int[] faces;
    private Random random;
    public int ValorDaFace { get; private set; }

    public Dado()
    {
        random = new Random();
        faces = new int[] { 1, 2, 3, 4, 5, 6 };
        LancarDado();
    }

    public void LancarDado()
    {
        int indiceAleatorio = random.Next(0, faces.Length);
        ValorDaFace = faces[indiceAleatorio];
    }

    public int GetFace()
    {
        return ValorDaFace;
    }
}

