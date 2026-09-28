using System;

namespace TrabalhoN1_POO
{
    public class Linha
    {
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;
        public string Cor;
        public int Espessura;

        public Linha()
        {
            Cor = "0,0,0";
            Espessura = 1;
        }

        public Linha(int x1, int y1, int x2, int y2, string cor = "0,0,0", int espessura = 1)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Cor = cor;
            Espessura = Math.Max(1, espessura);
        }

        public string ParaTexto()
        {
            return $"1;{X1};{Y1};{X2};{Y2};{Cor};{Espessura}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 7 && p[0] == "1")
            {
                X1 = int.Parse(p[1]);
                Y1 = int.Parse(p[2]);
                X2 = int.Parse(p[3]);
                Y2 = int.Parse(p[4]);
                Cor = p[5];
                Espessura = int.Parse(p[6]);
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}