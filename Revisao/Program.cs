using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            Console.WriteLine("1 - Inserir novo aluno;");
            Console.WriteLine("2 - Listar alunos;");
            Console.WriteLine("3 - Calcular média geral;");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsurio = Console.ReadLine();

            while(opcaoUsurio.ToUpper() != "X")
            {
                switch(opcaoUsurio)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("ESCOLHA UMA OPÇÃO:");
                Console.WriteLine("1 - Inserir novo aluno;");
                Console.WriteLine("2 - Listar alunos;");
                Console.WriteLine("3 - Calcular média geral;");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                opcaoUsurio = Console.ReadLine();

            }
        }
    }
}
