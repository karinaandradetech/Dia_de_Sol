using System;

public class Circulo : Forma
{
    public int X;
    public int Y;
    public int Raio;
    public string Cor;

    public Circulo() { }

    public Circulo(int x, int y, int raio, string cor)
    {
        X = x;
        Y = y;
        Raio = raio;
        Cor = cor;
    }

    public override string SalvarEmString()
    {
        return $"3;{X};{Y};{Raio};{Cor}";
    }

    public override void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public override void CarregarDeString(string dados)
    {
        string[] partes = dados.Split(';');
        X = int.Parse(partes[1]);
        Y = int.Parse(partes[2]);
        Raio = int.Parse(partes[3]);
        Cor = partes[4];
    }
}