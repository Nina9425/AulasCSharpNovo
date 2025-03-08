namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************DADOS INGRESADOS POR CONSOLA***************");

            Console.WriteLine("Ingrese el número de la cuenta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo inicial:");
            double saldo = double.Parse(Console.ReadLine());

            ContaCorrente cuenta0 = new ContaCorrente(numero, titular, saldo);

            cuenta0.ExibirSaldo();
                       
            Console.WriteLine("Ingrese el monto a depositar:");
            double montoDeposito = double.Parse(Console.ReadLine());// monto a depositar

            cuenta0.getDepositar(montoDeposito);// Realizar el depósito

           // cuenta0.ExibirSaldo();// saldo actualizado 

            Console.WriteLine("*************DADOS INGRESADOS PELO PROGRAMA***************");


            ContaCorrente cuenta1 = new ContaCorrente(12345, "Reyna Nina", 1000);
            cuenta1.ExibirSaldo();
            cuenta1.getDepositar(15);
           // cuenta1.ExibirSaldo();


            

        }
    }
}
