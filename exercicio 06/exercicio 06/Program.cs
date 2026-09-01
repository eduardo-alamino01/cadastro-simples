using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 06 - CADASTRO DE VEÍCULO

        Console.WriteLine("=================================");
        Console.WriteLine("        CADASTRO DE VEÍCULO");
        Console.WriteLine("=================================");

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Cor: ");
        string cor = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Está disponível para venda? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("       DADOS DO VEÍCULO");
        Console.WriteLine("=================================");

        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Disponível: " + disponivel);

        Console.ReadKey();
    }
}