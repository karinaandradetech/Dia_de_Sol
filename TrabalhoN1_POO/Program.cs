using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== MONSTANDO A IMAGEM VETORIAL ===");

        var imagem = new ImagemVetorial(600, 400);

        imagem.Formas.Add(new Circulo(520, 80, 40, "255,255,0"));
        imagem.Formas.Add(new Elipse(120, 70, 55, 25, "255,255,255"));
        imagem.Formas.Add(new Poligono(new List<int> { 0, 300, 150, 140, 300, 300 }, "128,128,128"));
        imagem.Formas.Add(new Linha(0, 300, 600, 300, "34,139,34", 4));
        imagem.Formas.Add(new Retangulo(430, 230, 30, 70, "139,69,19"));
        imagem.Formas.Add(new Circulo(445, 200, 55, "0,128,0"));
        imagem.Formas.Add(new TextoForma(200, 350, "Parque da Cidade", "0,0,0"));

        Console.WriteLine("\n--- DESENHO NO CONSOLE ---");
        imagem.Desenhar();

        // Ponto Extra: Salvar e Carregar de Arquivo
        string caminho = "imagem_vetorial.txt";
        imagem.SalvarEmArquivo(caminho);
        Console.WriteLine($"\n[PONTO EXTRA] Imagem salva no arquivo: {caminho}");

        var imagemCarregada = new ImagemVetorial();
        imagemCarregada.CarregarDeArquivo(caminho);
        Console.WriteLine("\n[PONTO EXTRA] Imagem recarregada do arquivo com sucesso!");
    }
}