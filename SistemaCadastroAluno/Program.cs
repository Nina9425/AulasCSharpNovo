namespace SistemaCadastroAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Aluno aluno1 = new Aluno();
            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos.Add(aluno1);*/

            
            List<string> alunos = new List<string>();

            

            while (true)
            {
                Console.Write("Ingresa el nombre del alumno (o 'listar' para terminar): ");
                string nome = Console.ReadLine();
                Console.Write("Ingresa el cpf (o 'listar' para terminar): ");
                string cpf = Console.ReadLine();

                if (nome.ToLower() == "listar")
                {
                    break; 
                }
                if (nome.ToLower() == "listar")
                {
                    break;
                }
                alunos.Add(nome);
                alunos.Add(cpf);

            }


            Console.WriteLine("\nLista de alumnos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }



        }
    }
}
