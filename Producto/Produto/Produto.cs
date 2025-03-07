using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{  

    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor
        public Produto(int quantidade, string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //metodo
        public double getTotalAmount() 
        {
            return Preco * Quantidade;
        }

        public string getDetailProduct()
        {
            return $"Nome: {Nome}, Preço: {Preco}, Quantidade : {Quantidade}";
        }




    }
}
