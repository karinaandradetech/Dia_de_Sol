public class Retangulo
{
    public int X;
    public int Y;
    public int Largura;
    public int Altura;
    public string Cor;

    public Retangulo() { }

    public Retangulo(int x, int y, int largura, int altura, string cor)
    {
        X = x;
        Y = y;
        Largura = largura;
        Altura = altura;
        Cor = cor;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public string SalvarEmString()
    {
        return $"2;{X};{Y};{Largura};{Altura};{Cor}";
    }

    public void CarregarDeString(string dados)
    {
        var partes = dados.Split(';');
        X = Convert.ToInt32(partes[1]);
        Y = Convert.ToInt32(partes[2]);
        Largura = Convert.ToInt32(partes[3]);
        Altura = Convert.ToInt32(partes[4]);
        Cor = partes[5];
    }
}