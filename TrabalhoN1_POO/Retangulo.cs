namespace TrabalhoN1_POO
{
    public class Retangulo
    {
        public int X;
        public int Y;
        public int Largura;
        public int Altura;
        public string Cor;

        public Retangulo()
        {
            Cor = "0,0,0";
        }

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
    }
}