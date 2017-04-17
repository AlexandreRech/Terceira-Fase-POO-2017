using System;
using System.Text;

namespace Unidade4.Exemplos
{
    public class ContaCorrente
    {
        private int _numero;

        private bool EhEspecial;
        private double _saldo;
        private double _limite;
        private Movimentacao[] _movimentacoes;
        private Cliente _titular;

        #region Método Constructor

        public ContaCorrente(double limiteInicial, int quantidadeMaximaOperacoes)
        {
            _limite = limiteInicial;
            _movimentacoes = new Movimentacao[quantidadeMaximaOperacoes];
        }

        #endregion 

        #region Propriedades

        public int Numero
        {
            get { return _numero; }
            set
            {
                if (value > 0)
                    _numero = value;
            }
        }

        public double Saldo
        {
            get { return _saldo + _limite; }
            
        }

        #endregion

        #region Interface pública da classe
        public void Sacar(double quantia)
        {
            if (quantia < Saldo)
            {
                double novoSaldo = _saldo - quantia;

                _saldo = novoSaldo;
               
                int posicaoVazia = PegarPosicaoVazia();

                Movimentacao movimentacao = new Movimentacao();
                movimentacao._tipo = "Débito";
                movimentacao._valor = quantia;

                _movimentacoes[posicaoVazia] = movimentacao;

            }
        }

        public void Depositar(double quantia)
        {
            double novoSaldo = _saldo + quantia;

            _saldo = novoSaldo;

            int posicaoVazia = PegarPosicaoVazia();

            Movimentacao movimentacao = new Movimentacao();
            movimentacao._tipo = "Crédito";
            movimentacao._valor = quantia;

            _movimentacoes[posicaoVazia] = movimentacao;
        }

        public void TransferirPara(ContaCorrente contaDestino, double quantia)
        {
            this.Sacar(quantia);

            contaDestino.Depositar(quantia);
        }

        public string ExibirExtrato()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nº da conta {0}", _numero).AppendLine();

            //conversa de objetos
            sb.AppendFormat("Nome do Titular {0}", _titular._nome).AppendLine();

            sb.AppendFormat("Movimentações: ").AppendLine();

            foreach (Movimentacao movimentacao in _movimentacoes)
            {
                if (movimentacao != null)
                {                    
                    sb.AppendFormat(movimentacao._descricao).AppendLine();
                }
            }

            sb.AppendFormat("Saldo atual: {0}", _saldo + _limite);

            return sb.ToString();
        }

        public int EmitirNumeroOperacoesRestantes()
        {
            int operacoesRestantes = 0;

            for (int i = 0; i < _movimentacoes.Length; i++)
            {
                if (_movimentacoes[i] == null)
                    operacoesRestantes++;
            }

            return operacoesRestantes;
        }

        #endregion
        private int PegarPosicaoVazia()
        {
            for (int i = 0; i < _movimentacoes.Length; i++)
            {
                if (_movimentacoes[i] == null)
                    return i;
            }

            return -1;
        }
       
    }
}
