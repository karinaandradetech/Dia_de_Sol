using System.Collections.Generic;
using Xunit;
using TrabalhoN1_POO;

namespace TrabalhoN1_POO.Tests
{
    public class PoligonoTest
    {
        [Fact]
        public void TestarParaTexto()
        {
            var p = new Poligono(new List<int> { 0, 0, 10, 0, 5, 10 }, "128,128,128");
            Assert.Equal("5;0;0;10;0;5;10;128,128,128", p.ParaTexto());
        }

        [Fact]
        public void TestarCarregar()
        {
            var p = new Poligono();
            p.Carregar("5;0;0;10;0;5;10;128,128,128");
            Assert.Equal(6, p.Pontos.Count);
        }

        [Fact]
        public void TestarDesenhar()
        {
            var p = new Poligono(new List<int> { 0, 0, 1, 1, 2, 2 }, "0,0,0");
            p.Desenhar();
            Assert.NotNull(p);
        }
    }
}