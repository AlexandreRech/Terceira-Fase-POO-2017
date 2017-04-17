using System;
namespace Unidade4.Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {            
            ContaCorrente conta1 = new ContaCorrente(1000, 5);

            ContaCorrente conta2 = new ContaCorrente(100, 10);

            Cliente cliente1 = new Cliente();
            cliente1._nome = "Flávio";

            conta1.Numero = 10;
                      
            conta1.Depositar(100);

            Console.WriteLine(conta1.Saldo);

            int qtdOperacoes = conta1.EmitirNumeroOperacoesRestantes();
            // qtdOperacoes deve ser igual a 7

            
        }
    }
}
