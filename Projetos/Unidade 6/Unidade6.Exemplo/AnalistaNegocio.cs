using System;

namespace Unidade6.Exemplo
{
    internal class AnalistaNegocio : Funcionario
    {
        public override double BuscarBonificacao()
        {
            return Salario * 0.13;
        }
    }
}