using System;
namespace Unidade4.Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Flávio");
            
            ContaCorrente conta1 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta2 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta3 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta4 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta5 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta6 = new ContaCorrente(cliente1, 1000, 5);
            ContaCorrente conta7 = new ContaCorrente(cliente1, 1000, 5);

            int totalContasCriadas = ContaCorrente.TotalContas;

            Console.WriteLine(totalContasCriadas);

            conta1.Depositar(1000);

            conta1.Sacar(100);
            conta1.Sacar(100);
            conta1.Sacar(100);
            conta1.Sacar(100);

            string resultado = conta1.ExibirExtrato();

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
