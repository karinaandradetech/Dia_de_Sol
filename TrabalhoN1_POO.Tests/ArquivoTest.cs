using System.IO;
using Xunit;

public class ArquivoTest
{
    [Fact]
    public void SalvarECarregarEmArquivo_MantemOsDadosDaImagem()
    {
        string caminho = Path.GetTempFileName();

        try
        {
            ImagemVetorial imagemOriginal = new ImagemVetorial(600, 400);
            imagemOriginal.Formas.Add(new Circulo(200, 150, 45, "255,128,0"));
            imagemOriginal.Formas.Add(new TextoForma(30, 200, "Bom Dia", "0,0,0"));

            imagemOriginal.SalvarEmArquivo(caminho);

            ImagemVetorial imagemCarregada = new ImagemVetorial();
            imagemCarregada.CarregarDeArquivo(caminho);

            Assert.Equal(imagemOriginal.SalvarEmString(), imagemCarregada.SalvarEmString());
        }
        finally
        {
            File.Delete(caminho);
        }
    }
}
