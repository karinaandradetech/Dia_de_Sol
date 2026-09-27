using System;
using System.Collections.Generic;

public class ImagemVetorial
{
    public int Largura;
    public int Altura;

    // Listas individuais de cada forma (já que não temos a classe pai 'Forma')
    public List<Linha> Linhas = new List<Linha>();
    public List<Retangulo> Retangulos = new List<Retangulo>();
    public List<Circulo> Circulos = new List<Circulo>();
    public List<Elipse> Elipses = new List<Elipse>();
    public List<Poligono> Poligonos = new List<Poligono>();
    public List<TextoForma> Textos = new List<TextoForma>();

    // Construtores
    public ImagemVetorial() { }

    public ImagemVetorial(int largura, int altura)
    {
        Largura = largura;
        Altura = altura;
    }

    // Método para desenhar/exibir tudo
    public void Desenhar()
    {
        Console.WriteLine($"0;{Largura};{Altura}");

        foreach (var l in Linhas) l.Desenhar();
        foreach (var r in Retangulos) r.Desenhar();
        foreach (var c in Circulos) c.Desenhar();
        foreach (var e in Elipses) e.Desenhar();
        foreach (var p in Poligonos) p.Desenhar();
        foreach (var t in Textos) t.Desenhar();
    }
}