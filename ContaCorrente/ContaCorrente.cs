using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
        public int Numero;
        public string Titular;
        public double Saldo;

        public ContaCorrente(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void getDepositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de valor es de: {valor}, agora tem saldo de:  {Saldo} ");
            }
            else
            {
                Console.WriteLine("Monto invalido - Não se adiciono nenhum valor ");
            }
            ExibirSaldo();
            

            }
        public void Sacar(double valor)
        {
            if (valor > 0 && valor<=Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de valor {Saldo}");
            }
            else
            {
                Console.WriteLine("monto a retirar é insuficiente.");
            }

            ExibirSaldo();
        
            }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo actual de {Titular}: {Saldo}");
        }




    }
}
