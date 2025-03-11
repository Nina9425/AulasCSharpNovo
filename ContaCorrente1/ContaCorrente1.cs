using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente1
{
    internal class ContaCorrente1
    {
        public string Titular;
        public double Saldo;
        public int NumeroConta;




        public ContaCorrente1(string titular, double saldo, int numeroConta)
        {
            Titular = titular;
            Saldo = saldo;
            NumeroConta=numeroConta;
        }

        public void Despositar(double valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
            Console.WriteLine($"deposito efetuado con sucesso novo saldo R${Saldo}");
        }


        public void sacar(double valorSaque)
        {
            if (Saldo >= valorSaque) {
                Saldo = Saldo - valorSaque;
                Console.WriteLine($"saque foi {Saldo}");
                return;

            }
            Console.WriteLine("saque finalizado");
        }





    }

    


}
