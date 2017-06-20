namespace ListaComprasWindowsApp
{
    public class ItemCompra
    {
        private decimal _quantidade;

        private Produto _produtoSelecionado;

        public ItemCompra(Produto produto, decimal quantidade)
        {
            _produtoSelecionado = produto;
            _quantidade = quantidade;
        }

        public decimal ObterSubTotalEstimado()
        {            
            return _produtoSelecionado.precoEstimado * _quantidade;
        }

        public override string ToString()
        {
            return $"{_quantidade} {_produtoSelecionado}: R$ {ObterSubTotalEstimado()}";
        }
    }
}