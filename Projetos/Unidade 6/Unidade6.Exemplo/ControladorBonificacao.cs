using System;

namespace Unidade6.Exemplo
{
    internal class ControladorBonificacao
    {
        public double ValorTotalBonificacao = 0;

        internal void RegistrarBonificao(Funcionario funcionario)
        {
            ValorTotalBonificacao += funcionario.BuscarBonificacao();
        }

       
    }
}