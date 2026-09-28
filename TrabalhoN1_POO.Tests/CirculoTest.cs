using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class CirculoTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var c = new Circulo(50, 50, 20, "255,255,0");
            Assert.Equal("3;50;50;20;255,255,0", c.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var c = new Circulo();
            c.Carregar("3;50;50;20;255,255,0");
            Assert.Equal(20, c.Raio);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var c = new Circulo(0, 0, 10, "0,0,0");
            c.Desenhar();
            Assert.NotNull(c);
        }
    }
}