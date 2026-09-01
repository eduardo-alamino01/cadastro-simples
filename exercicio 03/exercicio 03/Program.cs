using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 02 - CADASTRO DE PRODUTO

        Console.WriteLine("=================================");
        Console.WriteLine("      CADASTRO DE PRODUTO");
        Console.WriteLine("=================================");

        Console.Write("Nome do produto: ");
        string produto = Console.ReadLine();

        Console.Write("Código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Produto disponível? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("      DADOS DO PRODUTO");
        Console.WriteLine("=================================");

        Console.WriteLine("Produto: " + produto);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Disponível: " + disponivel);

        Console.ReadKey();
    }
}