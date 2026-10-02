using System;

public class TextoForma : Forma
{
    public int X;
    public int Y;
    public string Texto;
    public string Cor;

    public TextoForma() { }

    public TextoForma(int x, int y, string texto, string cor)
    {
        X = x;
        Y = y;
        Texto = texto;
        Cor = cor;
    }

    public override string SalvarEmString()
    {
        return $"6;{X};{Y};{Texto};{Cor}";
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
        Texto = partes[3];
        Cor = partes[4];
    }
}