using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class ElipseTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var e = new Elipse(100, 100, 40, 20, "255,0,0");
            Assert.Equal("4;100;100;40;20;255,0,0", e.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var e = new Elipse();
            e.Carregar("4;100;100;40;20;255,0,0");
            Assert.Equal(40, e.RaioX);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var e = new Elipse(0, 0, 10, 5, "0,0,0");
            e.Desenhar();
            Assert.NotNull(e);
        }
    }
}