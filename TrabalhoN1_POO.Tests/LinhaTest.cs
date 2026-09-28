using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class LinhaTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var linha = new Linha(0, 0, 10, 10, "255,0,0", 2);
            Assert.Equal("1;0;0;10;10;255,0,0;2", linha.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var linha = new Linha();
            linha.Carregar("1;0;0;10;10;255,0,0;2");
            Assert.Equal(10, linha.X2);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var linha = new Linha(0, 0, 5, 5, "0,0,0", 1);
            linha.Desenhar();
            Assert.NotNull(linha);
        }
    }
}