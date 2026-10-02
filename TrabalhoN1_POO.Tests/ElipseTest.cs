using Xunit;

public class ElipseTest
{
    [Fact]
    public void SalvarEmString_Elipse()
    {
        Elipse elipse = new Elipse(150, 120, 80, 35, "255,255,255");
        Assert.Equal("4;150;120;80;35;255,255,255", elipse.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Elipse()
    {
        Elipse elipse = new Elipse();
        elipse.CarregarDeString("4;150;120;80;35;255,255,255");
        Assert.Equal(150, elipse.X);
        Assert.Equal(120, elipse.Y);
        Assert.Equal(80, elipse.RaioX);
        Assert.Equal(35, elipse.RaioY);
        Assert.Equal("255,255,255", elipse.Cor);
    }
}