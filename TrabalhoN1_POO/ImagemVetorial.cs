using System;
using System.Collections.Generic;
using System.IO;

public class ImagemVetorial
{
    public int Largura;
    public int Altura;
    public List<Forma> Formas = new List<Forma>();

    public ImagemVetorial() { }

    public ImagemVetorial(int largura, int altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public string SalvarEmString()
    {
        string resultado = $"0;{Largura};{Altura}";
        foreach (Forma forma in Formas)
        {
            resultado = resultado + "\n" + forma.SalvarEmString();
        }
        return resultado;
    }

    public void Desenhar()
    {
        Console.WriteLine(SalvarEmString());
    }

    public void CarregarDeString(string dados)
    {
        Formas.Clear();
        string[] linhas = dados.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        if (linhas.Length == 0) return;

        string[] cabecalho = linhas[0].Split(';');
        Largura = int.Parse(cabecalho[1]);
        Altura = int.Parse(cabecalho[2]);

        for (int i = 1; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            string[] partes = linha.Split(';');
            int tipo = int.Parse(partes[0]);

            Forma forma = null;

            if (tipo == 1)
            {
                forma = new Linha();
            }
            else if (tipo == 2)
            {
                forma = new Retangulo();
            }
            else if (tipo == 3)
            {
                forma = new Circulo();
            }
            else if (tipo == 4)
            {
                forma = new Elipse();
            }
            else if (tipo == 5)
            {
                forma = new Poligono();
            }
            else if (tipo == 6)
            {
                forma = new TextoForma();
            }
            else
            {
                throw new ArgumentException("Tipo inválido");
            }

            forma.CarregarDeString(linha);
            Formas.Add(forma);
        }
    }

    public void SalvarEmArquivo(string caminho)
    {
        File.WriteAllText(caminho, SalvarEmString());
    }

    public void CarregarDeArquivo(string caminho)
    {
        string conteudo = File.ReadAllText(caminho);
        CarregarDeString(conteudo);
    }
}