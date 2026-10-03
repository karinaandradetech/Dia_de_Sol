using System;

public class Linha : Forma
{
    public int X1;
    public int Y1;
    public int X2;
    public int Y2;
    public string Cor;
    public int Largura;

    public Linha() { }

    public Linha(int x1, int y1, int x2, int y2, string cor, int largura)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        Cor = cor;
        if (largura < 1)
        {
            Largura = 1;
        }
        else
        {
            Largura = largura;
        }
    }

    public override string SalvarEmString()
    {
        return $"1;{X1};{Y1};{X2};{Y2};{Cor};{Largura}";
    }

    public override void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public override void CarregarDeString(string dados)
    {
        string[] partes = dados.Split(';');
        X1 = int.Parse(partes[1]);
        Y1 = int.Parse(partes[2]);
        X2 = int.Parse(partes[3]);
        Y2 = int.Parse(partes[4]);
        Cor = partes[5];
        Largura = int.Parse(partes[6]);
        if (Largura < 1)
        {
            Largura = 1;
        }
    }
}
