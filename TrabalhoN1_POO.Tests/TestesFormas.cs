using Xunit;
using TrabalhoN1_POO;
using System.Collections.Generic;

namespace TrabalhoN1_POO.Tests
{
    public class TestesFormas
    {
        [Fact]
        public void Linha_DeveGerarTextoCorreto()
        {
            // Arrange
            var linha = new Linha(0, 300, 600, 300, "34,139,34", 4);

            // Act
            string resultado = linha.ParaTexto();

            // Assert
            Assert.Equal("1;0;300;600;300;34,139,34;4", resultado);
        }

        [Fact]
        public void Retangulo_DeveGerarTextoCorreto()
        {
            // Arrange
            var retangulo = new Retangulo(430, 230, 30, 70, "139,69,19");

            // Act
            string resultado = retangulo.ParaTexto();

            // Assert
            Assert.Equal("2;430;230;30;70;139,69,19", resultado);
        }

        [Fact]
        public void Circulo_DeveGerarTextoCorreto()
        {
            // Arrange
            var circulo = new Circulo(520, 80, 40, "255,255,0");

            // Act
            string resultado = circulo.ParaTexto();

            // Assert
            Assert.Equal("3;520;80;40;255,255,0", resultado);
        }

        [Fact]
        public void Elipse_DeveGerarTextoCorreto()
        {
            // Arrange
            var elipse = new Elipse(120, 70, 55, 25, "255,255,255");

            // Act
            string resultado = elipse.ParaTexto();

            // Assert
            Assert.Equal("4;120;70;55;25;255,255,255", resultado);
        }

        [Fact]
        public void Poligono_DeveGerarTextoCorreto()
        {
            // Arrange
            var pontos = new List<int> { 0, 300, 150, 140, 300, 300 };
            var poligono = new Poligono(pontos, "128,128,128");

            // Act
            string resultado = poligono.ParaTexto();

            // Assert
            Assert.Equal("5;0;300;150;140;300;300;128,128,128", resultado);
        }

        [Fact]
        public void TextoForma_DeveGerarTextoCorreto()
        {
            // Arrange
            var texto = new TextoForma(200, 350, "Parque da Cidade", "0,0,0");

            // Act
            string resultado = texto.ParaTexto();

            // Assert
            Assert.Equal("6;200;350;Parque da Cidade;0,0,0", resultado);
        }

        [Fact]
        public void ImagemVetorial_DeveGerarTextoCompleto()
        {
            // Arrange
            var imagem = new ImagemVetorial(600, 400);
            imagem.Circulos.Add(new Circulo(520, 80, 40, "255,255,0"));

            // Act
            string resultado = imagem.GerarTexto();

            // Assert
            Assert.Contains("0;600;400", resultado);
            Assert.Contains("3;520;80;40;255,255,0", resultado);
        }
    }
}