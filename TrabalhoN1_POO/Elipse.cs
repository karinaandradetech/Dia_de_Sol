namespace TrabalhoN1_POO
{
    public class Elipse
    {
        public int X;
        public int Y;
        public int RaioX;
        public int RaioY;
        public string Cor;

        public Elipse()
        {
            Cor = "0,0,0";
        }

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
    }
}