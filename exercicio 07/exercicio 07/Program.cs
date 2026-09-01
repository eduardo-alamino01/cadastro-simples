using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 07 - CADASTRO DE JOGO

        Console.WriteLine("=================================");
        Console.WriteLine("         CADASTRO DE JOGO");
        Console.WriteLine("=================================");

        Console.Write("Nome do jogo: ");
        string jogo = Console.ReadLine();

        Console.Write("Plataforma: ");
        string plataforma = Console.ReadLine();

        Console.Write("Ano de lançamento: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade de jogadores: ");
        int jogadores = int.Parse(Console.ReadLine());

        Console.Write("O jogo está instalado? (true/false): ");
        bool instalado = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("          DADOS DO JOGO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + jogo);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano de lançamento: " + ano);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Jogadores: " + jogadores);
        Console.WriteLine("Instalado: " + instalado);

        Console.ReadKey();
    }
}