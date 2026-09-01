using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 08 - CADASTRO DE EVENTO

        Console.WriteLine("=================================");
        Console.WriteLine("        CADASTRO DE EVENTO");
        Console.WriteLine("=================================");

        Console.Write("Nome do evento: ");
        string nome = Console.ReadLine();

        Console.Write("Local: ");
        string local = Console.ReadLine();

        Console.Write("Data: ");
        string data = Console.ReadLine();

        Console.Write("Quantidade de participantes: ");
        int participantes = int.Parse(Console.ReadLine());

        Console.Write("Valor do ingresso: ");
        double ingresso = double.Parse(Console.ReadLine());

        Console.Write("O evento é gratuito? (true/false): ");
        bool gratuito = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("       DADOS DO EVENTO");
        Console.WriteLine("=================================");

        Console.WriteLine("Evento: " + nome);
        Console.WriteLine("Local: " + local);
        Console.WriteLine("Data: " + data);
        Console.WriteLine("Participantes: " + participantes);
        Console.WriteLine("Valor do ingresso: R$ " + ingresso);
        Console.WriteLine("Gratuito: " + gratuito);

        Console.ReadKey();
    }
}