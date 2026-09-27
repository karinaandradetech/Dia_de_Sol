public class Elipse
{
    public int X;
    public int Y;
    public int RaioX;
    public int RaioY;
    public string Cor;

    public Elipse() { }

    public Elipse(int x, int y, int raioX, int raioY, string cor)
    {
        X = x;
        Y = y;
        RaioX = raioX;
        RaioY = raioY;
        Cor = cor;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public string SalvarEmString()
    {
        return $"4;{X};{Y};{RaioX};{RaioY};{Cor}";
    }

    public void CarregarDeString(string dados)
    {
        var partes = dados.Split(';');
        X = Convert.ToInt32(partes[1]);
        Y = Convert.ToInt32(partes[2]);
        RaioX = Convert.ToInt32(partes[3]);
        RaioY = Convert.ToInt32(partes[4]);
        Cor = partes[5];
    }
}