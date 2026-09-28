using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class ImagemVetorialTest
    {
        [Fact]
        public void TestarGerarTexto()
        {
            var img = new ImagemVetorial(500, 400);
            Assert.StartsWith("0;500;400", img.GerarTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var img = new ImagemVetorial();
            img.Carregar("0;800;600\n3;100;100;50;255,0,0");
            Assert.Equal(800, img.Largura);
            Assert.Single(img.Circulos);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var img = new ImagemVetorial(100, 100);
            img.Desenhar();
            Assert.NotNull(img);
        }
    }
}