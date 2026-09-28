using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrabalhoN1_POO
{
    public class ImagemVetorial
    {
        public int Largura;
        public int Altura;

        public List<Linha> Linhas = new List<Linha>();
        public List<Retangulo> Retangulos = new List<Retangulo>();
        public List<Circulo> Circulos = new List<Circulo>();
        public List<Elipse> Elipses = new List<Elipse>();
        public List<Poligono> Poligonos = new List<Poligono>();
        public List<TextoForma> Textos = new List<TextoForma>();

        public ImagemVetorial() { Largura = 800; Altura = 600; }

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

        public void Carregar(string conteudo)
        {
            Linhas.Clear();
            Retangulos.Clear();
            Circulos.Clear();
            Elipses.Clear();
            Poligonos.Clear();
            Textos.Clear();

            string[] linhasTexto = conteudo.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var l in linhasTexto)
            {
                string linhaLimpa = l.Trim();
                if (string.IsNullOrEmpty(linhaLimpa)) continue;

                if (linhaLimpa.StartsWith("0;"))
                {
                    var p = linhaLimpa.Split(';');
                    Largura = int.Parse(p[1]);
                    Altura = int.Parse(p[2]);
                }
                else if (linhaLimpa.StartsWith("1;"))
                {
                    var obj = new Linha(); obj.Carregar(linhaLimpa); Linhas.Add(obj);
                }
                else if (linhaLimpa.StartsWith("2;"))
                {
                    var obj = new Retangulo(); obj.Carregar(linhaLimpa); Retangulos.Add(obj);
                }
                else if (linhaLimpa.StartsWith("3;"))
                {
                    var obj = new Circulo(); obj.Carregar(linhaLimpa); Circulos.Add(obj);
                }
                else if (linhaLimpa.StartsWith("4;"))
                {
                    var obj = new Elipse(); obj.Carregar(linhaLimpa); Elipses.Add(obj);
                }
                else if (linhaLimpa.StartsWith("5;"))
                {
                    var obj = new Poligono(); obj.Carregar(linhaLimpa); Poligonos.Add(obj);
                }
                else if (linhaLimpa.StartsWith("6;"))
                {
                    var obj = new TextoForma(); obj.Carregar(linhaLimpa); Textos.Add(obj);
                }
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(GerarTexto());
        }

        // --- PONTO EXTRA ---
        public void SalvarEmArquivo(string caminho)
        {
            File.WriteAllText(caminho, GerarTexto());
        }

        public void CarregarDeArquivo(string caminho)
        {
            if (File.Exists(caminho))
            {
                string conteudo = File.ReadAllText(caminho);
                Carregar(conteudo);
            }
        }
    }
}