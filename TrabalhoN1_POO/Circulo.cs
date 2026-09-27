public class Circulo
{
    public int X;
    public int Y;
    public int Raio;
    public string Cor;

    public Circulo() { }

    public Circulo(int x, int y, int raio, string cor)
    {
        X = x;
        Y = y;
        Raio = raio;
        Cor = cor;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public string SalvarEmString()
    {
        return $"3;{X};{Y};{Raio};{Cor}";
    }

    public void CarregarDeString(string dados)
    {
        var partes = dados.Split(';');
        X = Convert.ToInt32(partes[1]);
        Y = Convert.ToInt32(partes[2]);
        Raio = Convert.ToInt32(partes[3]);
        Cor = partes[4];
    }
}