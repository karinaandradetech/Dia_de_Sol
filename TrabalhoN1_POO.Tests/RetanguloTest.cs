using Xunit;

public class RetanguloTest
{
    [Fact]
    public void SalvarEmString_Retangulo()
    {
        Retangulo retangulo = new Retangulo(80, 40, 120, 60, "0,255,0");
        Assert.Equal("2;80;40;120;60;0,255,0", retangulo.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Retangulo()
    {
        Retangulo retangulo = new Retangulo();
        retangulo.CarregarDeString("2;80;40;120;60;0,255,0");
        Assert.Equal(80, retangulo.X);
        Assert.Equal(40, retangulo.Y);
        Assert.Equal(120, retangulo.Largura);
        Assert.Equal(60, retangulo.Altura);
        Assert.Equal("0,255,0", retangulo.Cor);
    }
}