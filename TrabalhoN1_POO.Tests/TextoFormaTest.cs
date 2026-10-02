using Xunit;

public class TextoFormaTest
{
    [Fact]
    public void SalvarEmString_Texto()
    {
        TextoForma texto = new TextoForma(30, 200, "Bom Dia", "0,0,0");
        Assert.Equal("6;30;200;Bom Dia;0,0,0", texto.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Texto()
    {
        TextoForma texto = new TextoForma();
        texto.CarregarDeString("6;30;200;Bom Dia;0,0,0");
        Assert.Equal(30, texto.X);
        Assert.Equal(200, texto.Y);
        Assert.Equal("Bom Dia", texto.Texto);
        Assert.Equal("0,0,0", texto.Cor);
    }
}