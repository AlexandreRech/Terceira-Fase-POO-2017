using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade7.Exemplo
{
    public class SaldoInsuficienteException : ApplicationException
    {
        public SaldoInsuficienteException(string message) 
            : base(message)
        {
        }
    }
}
