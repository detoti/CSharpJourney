using System;
namespace JogoDeDados.Model;

public class Dado
{

    private int[] faces;
    private Random random;
    public int ValorDaFace { get; private set; }

    public Dado()
    {
        random = new Random();
        faces = new int[] { 1, 2, 3, 4, 5, 6 };
        ValorDaFace = 1;
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


//public class Dado
//{

//    private Random random;
//    public int ValorDaFace { get; private set; }

//    public Dado()
//    {
//        random = new Random();
//        ValorDaFace = 1;
//    }

//    public void LancarDado()
//    {
//        ValorDaFace = random.Next(1, 7);
//    }

//    public int GetFace()
//    {
//        return ValorDaFace;
//    }
//}