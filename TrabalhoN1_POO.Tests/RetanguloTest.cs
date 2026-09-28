using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class RetanguloTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var ret = new Retangulo(10, 10, 50, 50, "0,255,0");
            Assert.Equal("2;10;10;50;50;0,255,0", ret.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var ret = new Retangulo();
            ret.Carregar("2;10;10;50;50;0,255,0");
            Assert.Equal(50, ret.Largura);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var ret = new Retangulo(0, 0, 10, 10, "0,0,0");
            ret.Desenhar();
            Assert.NotNull(ret);
        }
    }
}