using System;
using System.Collections.Generic;

public class Poligono : Forma
{
    public List<int> Pontos = new List<int>();
    public string Cor;

    public Poligono() { }

    public Poligono(List<int> pontos, string cor)
    {
        Pontos = pontos;
        Cor = cor;
    }

    public override string SalvarEmString()
    {
        return $"5;{string.Join(";", Pontos)};{Cor}";
    }

    public override void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public override void CarregarDeString(string dados)
    {
        string[] partes = dados.Split(';');
        Pontos.Clear();
        for (int i = 1; i < partes.Length - 1; i++)
        {
            Pontos.Add(int.Parse(partes[i]));
        }
        Cor = partes[partes.Length - 1];
    }
}