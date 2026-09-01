using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 03 - CADASTRO DE LIVRO

        Console.WriteLine("=================================");
        Console.WriteLine("        CADASTRO DE LIVRO");
        Console.WriteLine("=================================");

        Console.Write("Título do livro: ");
        string titulo = Console.ReadLine();

        Console.Write("Nome do autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ano de publicação: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Número de páginas: ");
        int paginas = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Livro disponível? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("        DADOS DO LIVRO");
        Console.WriteLine("=================================");

        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ano de publicação: " + ano);
        Console.WriteLine("Páginas: " + paginas);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Disponível: " + disponivel);

        Console.ReadKey();
    }
}