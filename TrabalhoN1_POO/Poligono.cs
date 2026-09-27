using System;
using System.Collections.Generic;

public class Poligono
{
    public List<int> Pontos = new List<int>(); // guarda pares x, y ex: x1, y1, x2, y2...
    public string Cor;

    public Poligono() { }

    public Poligono(List<int> pontos, string cor)
    {
        Pontos = pontos;
        Cor = cor;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public string SalvarEmString()
    {
        string pontosStr = string.Join(";", Pontos);
        return $"5;{pontosStr};{Cor}";
    }

    public void CarregarDeString(string dados)
    {
        var partes = dados.Split(';');
        Pontos.Clear();

        // A última parte é a Cor, do meio são os pontos
        for (int i = 1; i < partes.Length - 1; i++)
        {
            Pontos.Add(Convert.ToInt32(partes[i]));
        }
        Cor = partes[partes.Length - 1];
    }
}