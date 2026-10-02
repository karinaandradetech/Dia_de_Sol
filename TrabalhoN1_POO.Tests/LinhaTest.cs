using Xunit;

public class LinhaTest
{
    [Fact]
    public void SalvarEmString_Linha()
    {
        Linha linha = new Linha(10, 90, 250, 90, "255,0,0", 5);
        Assert.Equal("1;10;90;250;90;255,0,0;5", linha.SalvarEmString());
    }

    [Fact]
    public void CarregarString_Linha()
    {
        Linha linha = new Linha();
        linha.CarregarDeString("1;10;90;250;90;255,0,0;5");
        Assert.Equal(10, linha.X1);
        Assert.Equal(90, linha.Y1);
        Assert.Equal(250, linha.X2);
        Assert.Equal(90, linha.Y2);
        Assert.Equal("255,0,0", linha.Cor);
        Assert.Equal(5, linha.Largura);
    }

    [Fact]
    public void Linha_LarguraMenorQueUm_DeveAjustarParaUm()
    {
        Linha linha = new Linha(0, 0, 10, 10, "0,0,0", -5);
        Assert.Equal(1, linha.Largura);
    }
}