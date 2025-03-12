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
      //  public int Id;
        public string Nome;
        public int Idade;
        public string Matricula;
        public string Email;
        public string Telefone;
        public string Genero;       
        public string Curso;
        

       

        public Aluno(string nome, int idade, string matricula, string curso, string telefone, string email)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Curso = curso;
            Telefone = telefone;
            Email = email;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Matrícula: {Matricula}, Curso:{Curso},Telefone:[ {Telefone}], Email [{Email}]";
        }
    }

}