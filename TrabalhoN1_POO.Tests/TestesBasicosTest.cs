using Xunit;
using System.Collections.Generic;
public class TestesBasicosTest
{
    [Fact]
    public void ImagemVetorial_SalvarECarregar_ImagemCompleta()
    {
        ImagemVetorial imgOriginal = new ImagemVetorial(600, 400);
        imgOriginal.Formas.Add(new Circulo(520, 80, 40, "255,255,0"));
        imgOriginal.Formas.Add(new Elipse(120, 70, 55, 25, "255,255,255"));
        imgOriginal.Formas.Add(new Poligono(new List<int> { 0, 300, 150, 140, 300, 300 }, "128,128,128"));
        imgOriginal.Formas.Add(new Linha(0, 300, 600, 300, "34,139,34", 4));
        imgOriginal.Formas.Add(new Retangulo(430, 230, 30, 70, "139,69,19"));
        imgOriginal.Formas.Add(new Circulo(445, 200, 55, "0,128,0"));
        imgOriginal.Formas.Add(new TextoForma(200, 350, "Parque da Cidade", "0,0,0"));

        string dadosSalvos = imgOriginal.SalvarEmString();

        ImagemVetorial imgCarregada = new ImagemVetorial();
        imgCarregada.CarregarDeString(dadosSalvos);

        Assert.Equal(600, imgCarregada.Largura);
        Assert.Equal(400, imgCarregada.Altura);
        Assert.Equal(7, imgCarregada.Formas.Count);
    }
}