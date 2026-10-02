using Xunit;

public class CirculoTest
{
    [Fact]
    public void SalvarEmString_Circulo()
    {
        Circulo circulo = new Circulo(200, 150, 45, "255,128,0");
        Assert.Equal("3;200;150;45;255,128,0", circulo.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Circulo()
    {
        Circulo circulo = new Circulo();
        circulo.CarregarDeString("3;200;150;45;255,128,0");
        Assert.Equal(200, circulo.X);
        Assert.Equal(150, circulo.Y);
        Assert.Equal(45, circulo.Raio);
        Assert.Equal("255,128,0", circulo.Cor);
    }
}