using System;
using System.Collections.Generic;

namespace TrabalhoN1_POO
{
    public class Poligono
    {
        public List<int> Pontos = new List<int>();
        public string Cor;

        public Poligono() { Cor = "0,0,0"; }

        public Poligono(List<int> pontos, string cor = "0,0,0")
        {
            Pontos = pontos ?? new List<int>();
            Cor = cor;
        }

        public string ParaTexto()
        {
            string pontosTexto = string.Join(";", Pontos);
            return $"5;{pontosTexto};{Cor}";
        }

        public void Carregar(string dados)
        {
            var p = dados.Split(';');
            if (p.Length >= 3 && p[0] == "5")
            {
                Pontos.Clear();
                for (int i = 1; i < p.Length - 1; i++)
                {
                    Pontos.Add(int.Parse(p[i]));
                }
                Cor = p[p.Length - 1];
            }
        }

        public void Desenhar()
        {
            Console.WriteLine(ParaTexto());
        }
    }
}