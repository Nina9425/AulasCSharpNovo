namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cuenta1 = new ContaCorrente(12345, "Reyna Nina", 1000);
            cuenta1.ExibirSaldo();
            cuenta1.getDepositar(15);
            cuenta1.ExibirSaldo();


            

        }
    }
}
