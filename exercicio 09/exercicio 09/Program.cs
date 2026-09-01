using System;

class Program
{
    static void Main()
    {
        // EXERCÍCIO 09 - PERFIL DE USUÁRIO

        Console.WriteLine("=================================");
        Console.WriteLine("        PERFIL DO USUÁRIO");
        Console.WriteLine("=================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Nome de usuário: ");
        string usuario = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Perfil está ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n=================================");
        Console.WriteLine("        PERFIL CADASTRADO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Usuário: " + usuario);
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Altura: " + altura + " metros");
        Console.WriteLine("Perfil ativo: " + ativo);

        Console.ReadKey();
    }
}