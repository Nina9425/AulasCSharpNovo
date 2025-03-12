using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarAlunos
{
    class Aluno
    {
        public int Id;
        public string Nome;
        public int Idade;        
        public string Matricula;
        public string Email;
        public string Telefone;
        public string Genero;
        public string Curso;


    }

    class CadastroAlunos
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int limiteAlunos;

        public CadastroAlunos(int limite)
        {
            limiteAlunos = limite;
        }

        public void AdicionarAluno(int id, string nome, int idade, string matricula, string curso, string telefone, string email)
        {
            if (alunos.Count >= limiteAlunos)
            {
                Console.WriteLine("Limite de alunos atingido!");
                return;
            }
            alunos.Add(new Aluno { Id = id, Nome = nome, Idade = idade, Matricula=matricula, Curso=curso, Telefone=telefone, Email=email });
            Console.WriteLine($"Aluno {nome} adicionado com sucesso!");
        }
        
        public void ListarAlunos()
        {
            Console.WriteLine("Lista de alunos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.Nome}, Idade: {aluno.Idade}, Matricula:{aluno.Matricula},Curso:{aluno.Curso},Telefono:{aluno.Telefone},Email:{aluno.Email}");
            }
        }
    }
}