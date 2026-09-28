using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class TextoFormaTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var t = new TextoForma(10, 20, "Teste", "0,0,0");
            Assert.Equal("6;10;20;Teste;0,0,0", t.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var t = new TextoForma();
            t.Carregar("6;10;20;Teste;0,0,0");
            Assert.Equal("Teste", t.Conteudo);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var t = new TextoForma(0, 0, "Olá", "0,0,0");
            t.Desenhar();
            Assert.NotNull(t);
        }
    }
}