using Xunit;
using TrabalhoN1_POO;
using System.Collections.Generic;

namespace TrabalhoN1_POO.Tests
{
    public class TestesBasicosTest
    {
        [Fact]
        public void Salvar_Linha()
        {
            var l = new Linha(10, 90, 250, 90, "255,0,0", 5);
            Assert.Equal("1;10;90;250;90;255,0,0;5", l.ParaTexto());
        }

        [Fact]
        public void Salvar_Retangulo()
        {
            var r = new Retangulo(80, 40, 120, 60, "0,255,0");
            Assert.Equal("2;80;40;120;60;0,255,0", r.ParaTexto());
        }

        [Fact]
        public void Salvar_Circulo()
        {
            var c = new Circulo(200, 150, 45, "255,128,0");
            Assert.Equal("3;200;150;45;255,128,0", c.ParaTexto());
        }

        [Fact]
        public void Salvar_Elipse()
        {
            var e = new Elipse(150, 120, 80, 35, "255,255,255");
            Assert.Equal("4;150;120;80;35;255,255,255", e.ParaTexto());
        }

        [Fact]
        public void Salvar_Poligono()
        {
            var p = new Poligono(new List<int> { 10, 10, 110, 10, 60, 90 }, "0,0,255");
            Assert.Equal("5;10;10;110;10;60;90;0,0,255", p.ParaTexto());
        }

        [Fact]
        public void Salvar_Texto()
        {
            var t = new TextoForma(30, 200, "Bom Dia", "0,0,0");
            Assert.Equal("6;30;200;Bom Dia;0,0,0", t.ParaTexto());
        }

        [Fact]
        public void Carregar_Linha()
        {
            var l = new Linha();
            l.Carregar("1;10;90;250;90;255,0,0;5");
            Assert.Equal(10, l.X1);
            Assert.Equal(90, l.Y1);
            Assert.Equal(250, l.X2);
            Assert.Equal(90, l.Y2);
            Assert.Equal("255,0,0", l.Cor);
            Assert.Equal(5, l.Espessura);
        }

        [Fact]
        public void Carregar_ImagemVetorial()
        {
            string texto = "0;600;400\n3;520;80;40;255,255,0\n6;200;350;Parque da Cidade;0,0,0";
            var img = new ImagemVetorial();
            img.Carregar(texto);

            Assert.Equal(600, img.Largura);
            Assert.Equal(400, img.Altura);
            Assert.Single(img.Circulos);
            Assert.Single(img.Textos);
        }
    }
}