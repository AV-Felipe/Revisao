using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] aluno = new Alunos[5];
            int indiceAluno = 0;
            
            string opcaoUsurio = obterOpcaoUsuario();
          
            while (opcaoUsurio.ToUpper() != "X")
            {
                switch (opcaoUsurio)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Alunos alunoNovo = new Alunos();
                        alunoNovo.Nome = Console.ReadLine();

                        Console.WriteLine($"Informe a nota do aluno {alunoNovo.Nome}:");
                        //alunos.Nota = decimal.Parse(Console.ReadLine()); esse código pode gerar problemas se o valor informado não for conversível em decimal
                        if (decimal.TryParse(Console.ReadLine(), out decimal notaInformada))
                        {
                            alunoNovo.Nota = notaInformada;

                        }
                        else
                        {
                            throw new ArgumentException("O valor informado para a nota deve ser decimal");
                        }

                        aluno[indiceAluno] = alunoNovo;
                        
                        if(indiceAluno<=3)
                        {
                            indiceAluno++;
                        }
                        else
                        {
                            Console.WriteLine("Limite máximo de alunos atingido. O primeiro aluno será sobrescrito");
                            indiceAluno=0;
                        }


                        break;

                    case "2":
                        foreach (Alunos  alunoListado in aluno)
                        {
                            if(alunoListado.Nome!=null)
                            {
                            Console.WriteLine($"Aluno: {alunoListado.Nome} - Nota: {alunoListado.Nota}");
                            }
                        }
                        break;

                    case "3":
                        int contagemAlunos = 0;
                        decimal mediaTurma = 0;
                        foreach (Alunos alunoListado in aluno)
                        {
                            if(alunoListado.Nome!=null)
                            {
                                mediaTurma=mediaTurma+alunoListado.Nota;
                                contagemAlunos++;
                            }
                        }
                        mediaTurma=mediaTurma/contagemAlunos;
                        Console.WriteLine($"A média geral da turma é de {mediaTurma}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsurio = obterOpcaoUsuario();

            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
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
