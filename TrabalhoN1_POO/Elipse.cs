using System;

public class Elipse : Forma
{
    public int X;
    public int Y;
    public int RaioX;
    public int RaioY;
    public string Cor;

    public Elipse() { }

    public Elipse(int x, int y, int raioX, int raioY, string cor)
    {
        X = x;
        Y = y;
        RaioX = raioX;
        RaioY = raioY;
        Cor = cor;
    }

    public override string SalvarEmString()
    {
        return $"4;{X};{Y};{RaioX};{RaioY};{Cor}";
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
        RaioX = int.Parse(partes[3]);
        RaioY = int.Parse(partes[4]);
        Cor = partes[5];
    }
}