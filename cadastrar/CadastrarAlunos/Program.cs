using System.ComponentModel.DataAnnotations;

namespace CadastrarAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o limite de alunos: ");
                int limite = int.Parse(Console.ReadLine());
                CadastroAlunos cadastro = new CadastroAlunos(limite);

                while (true)
                {


                    Console.WriteLine("\nEscolha uma opção:");
                    Console.WriteLine("1 - Adicionar Aluno");
                    Console.WriteLine("2 - Listar Alunos");
                    Console.WriteLine("3 - Sair");
                    Console.Write("Opção: ");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 3)
                        break;

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o ID do aluno: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.Write("Digite a idade do aluno: ");
                            int idade = int.Parse(Console.ReadLine());
                            string matricula = Console.ReadLine();
                            Console.Write("Digite a matricula do aluno: ");
                            string email = Console.ReadLine();
                            Console.Write("Digite a email do aluno: ");
                            string telefono = Console.ReadLine();
                           Console.Write("Digite a telefono do aluno: ");
                            string genero = Console.ReadLine();
                            Console.Write("Digite o genero do aluno: ");
                            string curso = Console.ReadLine();
                            Console.Write("Digite o curso do aluno: ");
                            cadastro.AdicionarAluno(id, nome, idade, matricula,curso,telefono, email);
                            break;
                            
                        
                        case 2:
                            cadastro.ListarAlunos();
                            break;
                        case 3:
                    Console.WriteLine("Saindo do programa...");
                    return;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
            }
        }
    }
}