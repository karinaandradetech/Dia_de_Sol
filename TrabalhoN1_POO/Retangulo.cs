using System;

public class Retangulo : Forma
{
    public int X;
    public int Y;
    public int Largura;
    public int Altura;
    public string Cor;

    public Retangulo() { }

    public Retangulo(int x, int y, int largura, int altura, string cor)
    {
        X = x;
        Y = y;
        Largura = largura;
        Altura = altura;
        Cor = cor;
    }

    public override string SalvarEmString()
    {
        return $"2;{X};{Y};{Largura};{Altura};{Cor}";
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
        Largura = int.Parse(partes[3]);
        Altura = int.Parse(partes[4]);
        Cor = partes[5];
    }
}