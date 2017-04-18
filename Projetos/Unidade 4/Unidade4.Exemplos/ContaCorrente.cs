using System;
using System.Text;

namespace Unidade4.Exemplos
{
    public class ContaCorrente
    {
        #region Atributos Privados
        private int _numero;

        private double _saldo;
        private double _limite;
        private Movimentacao[] _movimentacoes;
        private Cliente _titular;
        #endregion

        public static int TotalContas;

        #region Métodos Constructores

        //Exemplo de como fica a chamada:
        //Cliente novoCliente = new Cliente("Alexandre Rech")
        //ContaCorrente novaConta = new ContaCorrente(novoCliente);

        public ContaCorrente(Cliente cliente)
        {
            _titular = cliente;
            _limite = 300;
            _movimentacoes = new Movimentacao[3];

            TotalContas++;
        }

        public ContaCorrente(Cliente cliente, double limiteInicial, int quantidadeMaximaOperacoes)
        {
            _titular = cliente;
            _limite = limiteInicial;
            _movimentacoes = new Movimentacao[quantidadeMaximaOperacoes];

            TotalContas++;
        }
        

        #endregion 

        #region Propriedades

        public int Numero
        {
            get
            {
                return _numero;
            }
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
        /// <summary>
        /// Este método modifica o saldo da conta.
        /// Não deve modificar o saldo, caso a quantia
        /// seja maior que o Saldo + Limite        
        /// </summary>
        /// <param name="q">Quantia a ser sacada</param>
        public void Sacar(double quantia)
        {
            if (quantia < Saldo)
            {
                _saldo -= quantia;

                RegistrarMovimentacao(quantia, "Débito");
            }
        }        

        public void Depositar(double quantia)
        {
            _saldo += quantia;

            RegistrarMovimentacao(quantia, "Crédito");
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

            //conversa dos objetos: _titular.NomeCompleto  
            sb.AppendFormat("Nome Completo do Titular {0}", _titular.NomeCompleto).AppendLine();

            sb.AppendFormat("Movimentações: ").AppendLine();

            foreach (Movimentacao movimentacao in _movimentacoes)
            {
                if (movimentacao != null)
                {
                    //conversa dos objetos: movimentacao.ObtemDescricao()                 
                    sb.AppendFormat(movimentacao.ObtemDescricao()).AppendLine();
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

        #region Métodos Privados

        private void RegistrarMovimentacao(double quantia, string tipoMovimentacao)
        {
            int posicaoVazia = PegarPosicaoVazia();

            _movimentacoes[PegarPosicaoVazia()] = new Movimentacao(tipoMovimentacao, quantia);
        }

        private int PegarPosicaoVazia()
        {
            for (int i = 0; i < _movimentacoes.Length; i++)
            {
                if (_movimentacoes[i] == null)
                    return i;
            }

            return -1;
        }

        #endregion
    }
}
