using System.Collections.Generic;

namespace TrabalhoN1_POO
{
    public class Poligono
    {
        public List<int> Pontos = new List<int>();
        public string Cor;

        public Poligono()
        {
            Cor = "0,0,0";
        }

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
    }
}