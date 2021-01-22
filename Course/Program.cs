using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p.Idade = int.Parse(Console.ReadLine());

            Pessoa p1 = new Pessoa();
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            if (p.Idade > p1.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " +p.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " +p1.Nome);
            }

        }
    }
}
