using Xunit;
using System.Collections.Generic;

public class ImagemVetorialTest
{
    [Fact]
    public void SalvarEmString_ImagemVetorial()
    {
        ImagemVetorial img = new ImagemVetorial(600, 400);
        img.Formas.Add(new Circulo(520, 80, 40, "255,255,0"));
        img.Formas.Add(new Elipse(120, 70, 55, 25, "255,255,255"));
        img.Formas.Add(new Poligono(new List<int> { 0, 300, 150, 140, 300, 300 }, "128,128,128"));
        img.Formas.Add(new Linha(0, 300, 600, 300, "34,139,34", 4));
        img.Formas.Add(new Retangulo(430, 230, 30, 70, "139,69,19"));
        img.Formas.Add(new Circulo(445, 200, 55, "0,128,0"));
        img.Formas.Add(new TextoForma(200, 350, "Parque da Cidade", "0,0,0"));

        string esperado = "0;600;400\n" +
                         "3;520;80;40;255,255,0\n" +
                         "4;120;70;55;25;255,255,255\n" +
                         "5;0;300;150;140;300;300;128,128,128\n" +
                         "1;0;300;600;300;34,139,34;4\n" +
                         "2;430;230;30;70;139,69,19\n" +
                         "3;445;200;55;0,128,0\n" +
                         "6;200;350;Parque da Cidade;0,0,0";

        Assert.Equal(esperado, img.SalvarEmString().Replace("\r\n", "\n"));
    }

    [Fact]
    public void CarregarDeString_ImagemVetorial()
    {
        string entrada = "0;600;400\n" +
                        "3;520;80;40;255,255,0\n" +
                        "4;120;70;55;25;255,255,255\n" +
                        "5;0;300;150;140;300;300;128,128,128\n" +
                        "1;0;300;600;300;34,139,34;4\n" +
                        "2;430;230;30;70;139,69,19\n" +
                        "3;445;200;55;0,128,0\n" +
                        "6;200;350;Parque da Cidade;0,0,0";

        ImagemVetorial img = new ImagemVetorial();
        img.CarregarDeString(entrada);

        Assert.Equal(600, img.Largura);
        Assert.Equal(400, img.Altura);
        Assert.Equal(7, img.Formas.Count);
    }
}