public class TextoForma
{
    public int X;
    public int Y;
    public string Texto;
    public string Cor;

    public TextoForma() { }

    public TextoForma(int x, int y, string texto, string cor)
    {
        X = x;
        Y = y;
        Texto = texto;
        Cor = cor;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public string SalvarEmString()
    {
        return $"6;{X};{Y};{Texto};{Cor}";
    }

    public void CarregarDeString(string dados)
    {
        var partes = dados.Split(';');
        X = Convert.ToInt32(partes[1]);
        Y = Convert.ToInt32(partes[2]);
        Texto = partes[3];
        Cor = partes[4];
    }
}