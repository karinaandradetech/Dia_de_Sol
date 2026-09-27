using System;
using System.Collections.Generic;

namespace TrabalhoN1_POO
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== MONTANDO A IMAGEM VETORIAL ===");

            var imagem = new ImagemVetorial(600, 400);

            imagem.Circulos.Add(new Circulo(520, 80, 40, "255,255,0"));
            imagem.Elipses.Add(new Elipse(120, 70, 55, 25, "255,255,255"));
            imagem.Poligonos.Add(new Poligono(new List<int> { 0, 300, 150, 140, 300, 300 }, "128,128,128"));
            imagem.Linhas.Add(new Linha(0, 300, 600, 300, "34,139,34", 4));
            imagem.Retangulos.Add(new Retangulo(430, 230, 30, 70, "139,69,19"));
            imagem.Textos.Add(new TextoForma(200, 350, "Parque da Cidade", "0,0,0"));

            Console.WriteLine("\n--- DESENHO GERADO NO CONSOLE ---");
            Console.WriteLine(imagem.GerarTexto());
        }
    }
}