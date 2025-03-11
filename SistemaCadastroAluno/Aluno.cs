using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroAluno
{
    internal class Aluno
    {
        public string Nome;
        public string CPF;
        public string Email;
        public string Telefono;
        public string Genero;
        public int Matricula;
        public string Curso;
        public int operacao;

        public Aluno(string nome, string cpf, string email, string telefono, string genero, int matricula, string curso)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefono = telefono;
            Genero = genero;
            Matricula = matricula;
            Curso = curso;
        }

       /* public void Cadastrar()
        {
            Console.WriteLine("Ingrese Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Ingrese CPF:");
            CPF = Console.ReadLine();
            Console.WriteLine("VERIFICADO Y CADASTRADO");

            Console.Write("Opção: ");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {

                case 1:








            }
        }*/
    }
}
