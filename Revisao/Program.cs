using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] aluno = new Alunos[5];

            string opcaoUsurio = obterOpcaoUsuario();
          
            while (opcaoUsurio.ToUpper() != "X")
            {
                switch (opcaoUsurio)
                {
                    case "1":
                        //TODO: cadastro de aluno
                        break;

                    case "2":
                        //TODO: listagem de alunos
                        break;

                    case "3":
                        //TODO: cálculo de média
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsurio = obterOpcaoUsuario();

            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            Console.WriteLine("1 - Inserir novo aluno;");
            Console.WriteLine("2 - Listar alunos;");
            Console.WriteLine("3 - Calcular média geral;");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsurio = Console.ReadLine();
            return opcaoUsurio;
        }
    }
}
