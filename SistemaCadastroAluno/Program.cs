namespace SistemaCadastroAluno
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno(alunos);
                        break;
                    case 2:
                        ListarAlunos(alunos);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        static void CadastrarAluno(List<Aluno> alunos)
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o curso do aluno:");
            string curso = Console.ReadLine();

            Console.WriteLine("Digite o telefone:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o email:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do aluno:");
            string matricula = Console.ReadLine();

            Aluno aluno = new Aluno(nome, idade, matricula, curso, telefone, email);

            alunos.Add(aluno);

            Console.WriteLine("Aluno cadastrado com sucesso!\n");
        }

        static void ListarAlunos(List<Aluno> alunos)
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("NENHUM ALUNO CADASTRADO.\n");
                return;
            }

            Console.WriteLine("LISTA DE ALUNOS CADASTRADOS:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();
        }
    }
}