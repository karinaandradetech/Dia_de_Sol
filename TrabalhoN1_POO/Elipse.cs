using System;

namespace TrabalhoN1_POO
{
    public class Elipse
    {
        public int X;
        public int Y;
        public int RaioX;
        public int RaioY;
        public string Cor;

        public Elipse() { Cor = "0,0,0"; }

        public Elipse(int x, int y, int raioX, int raioY, string cor = "0,0,0")
        {
            X = x;
            Y = y;
            RaioX = raioX;
            RaioY = raioY;
            Cor = cor;
        }

        public string ParaTexto()
        {
            return $"4;{X};{Y};{RaioX};{RaioY};{Cor}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 6 && p[0] == "4")
            {
                X = int.Parse(p[1]);
                Y = int.Parse(p[2]);
                RaioX = int.Parse(p[3]);
                RaioY = int.Parse(p[4]);
                Cor = p[5];
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}