using System;

namespace TrabalhoN1_POO
{
    public class Retangulo
    {
        public int X;
        public int Y;
        public int Largura;
        public int Altura;
        public string Cor;

        public Retangulo() { Cor = "0,0,0"; }

        public Retangulo(int x, int y, int largura, int altura, string cor = "0,0,0")
        {
            X = x;
            Y = y;
            Largura = largura;
            Altura = altura;
            Cor = cor;
        }

        public string ParaTexto()
        {
            return $"2;{X};{Y};{Largura};{Altura};{Cor}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 6 && p[0] == "2")
            {
                X = int.Parse(p[1]);
                Y = int.Parse(p[2]);
                Largura = int.Parse(p[3]);
                Altura = int.Parse(p[4]);
                Cor = p[5];
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}