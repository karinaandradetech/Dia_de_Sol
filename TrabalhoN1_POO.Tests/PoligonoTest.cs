using Xunit;
using System.Collections.Generic;

public class PoligonoTest
{
    [Fact]
    public void SalvarEmString_Poligono()
    {
        Poligono poligono = new Poligono(new List<int> { 10, 10, 110, 10, 60, 90 }, "0,0,255");
        Assert.Equal("5;10;10;110;10;60;90;0,0,255", poligono.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Poligono()
    {
        Poligono poligono = new Poligono();
        poligono.CarregarDeString("5;10;10;110;10;60;90;0,0,255");
        Assert.Equal(new List<int> { 10, 10, 110, 10, 60, 90 }, poligono.Pontos);
        Assert.Equal("0,0,255", poligono.Cor);
    }
}