using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoN1_POO
{
    public class ImagemVetorial
    {
        public int Largura;
        public int Altura;

        // Listas individuais para cada forma (sem herança)
        public List<Linha> Linhas = new List<Linha>();
        public List<Retangulo> Retangulos = new List<Retangulo>();
        public List<Circulo> Circulos = new List<Circulo>();
        public List<Elipse> Elipses = new List<Elipse>();
        public List<Poligono> Poligonos = new List<Poligono>();
        public List<TextoForma> Textos = new List<TextoForma>();

        public ImagemVetorial()
        {
            Largura = 800;
            Altura = 600;
        }

        public ImagemVetorial(int largura, int altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public string GerarTexto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"0;{Largura};{Altura}");

            foreach (var item in Linhas) sb.AppendLine(item.ParaTexto());
            foreach (var item in Retangulos) sb.AppendLine(item.ParaTexto());
            foreach (var item in Circulos) sb.AppendLine(item.ParaTexto());
            foreach (var item in Elipses) sb.AppendLine(item.ParaTexto());
            foreach (var item in Poligonos) sb.AppendLine(item.ParaTexto());
            foreach (var item in Textos) sb.AppendLine(item.ParaTexto());

            return sb.ToString().TrimEnd();
        }
    }
}