namespace TrabalhoN1_POO
{
    public class TextoForma
    {
        public int X;
        public int Y;
        public string Conteudo;
        public string Cor;

        public TextoForma()
        {
            Conteudo = "";
            Cor = "0,0,0";
        }

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
    }
}