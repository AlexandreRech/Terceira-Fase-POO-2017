using System;

namespace Unidade4.Exemplos
{
    public class Movimentacao
    {
        private double _valor;

        private string _tipo; //crédito e débito

        public Movimentacao(string tipo, double valor)
        {
            if (tipo != "Débito")
                if (tipo != "Crédito")
                    throw new InvalidOperationException("Tipo inválido");

            _tipo = tipo;
            _valor = valor;
        }

        public string ObtemDescricao()
        {
            return _tipo + " de R$ " + _valor + " reais";
        }
    }
}
