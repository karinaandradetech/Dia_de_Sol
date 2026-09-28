using System;

namespace TrabalhoN1_POO
{
    public class TextoForma
    {
        public int X;
        public int Y;
        public string Conteudo;
        public string Cor;

        public TextoForma() { Conteudo = ""; Cor = "0,0,0"; }

        public TextoForma(int x, int y, string conteudo, string cor = "0,0,0")
        {
            X = x;
            Y = y;
            Conteudo = conteudo;
            Cor = cor;
        }

        public string ParaTexto()
        {
            return $"6;{X};{Y};{Conteudo};{Cor}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 5 && p[0] == "6")
            {
                X = int.Parse(p[1]);
                Y = int.Parse(p[2]);
                Conteudo = p[3];
                Cor = p[4];
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}