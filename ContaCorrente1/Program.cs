using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente1 conta=new ContaCorrente1("reyna",500,44545);
            Console.WriteLine(conta.Saldo);
            conta.Despositar(200);
            conta.sacar(121);
        }
    }
}
