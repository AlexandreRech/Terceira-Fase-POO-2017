using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.Exemplo
{
    public class ContaCorrente
    {
        public ContaCorrente(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public double Saldo { get;  private set; }

        public int Numero { get; set; }

        public void Sacar(double quantia)
        {
            if(Saldo >= quantia)
            {
                Saldo -= quantia;
            }
            else
            {
                throw new SaldoInsuficienteException("Saldo Insuficiente");
            }
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
