using System;

namespace TrabalhoN1_POO
{
    public class Circulo
    {
        public int X;
        public int Y;
        public int Raio;
        public string Cor;

        public Circulo() { Cor = "0,0,0"; }

        public Circulo(int x, int y, int raio, string cor = "0,0,0")
        {
            X = x;
            Y = y;
            Raio = raio;
            Cor = cor;
        }

        public string ParaTexto()
        {
            return $"3;{X};{Y};{Raio};{Cor}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 5 && p[0] == "3")
            {
                X = int.Parse(p[1]);
                Y = int.Parse(p[2]);
                Raio = int.Parse(p[3]);
                Cor = p[4];
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}