namespace ListaComprasWindowsApp
{
    public class ItemCompra
    {
        private int _quantidade;

        private Produto _produtoSelecionado;

        public ItemCompra(Produto produto, int quantidade)
        {
            _produtoSelecionado = produto;
            _quantidade = quantidade;
        }

        public double ObterSubTotalEstimado()
        {            
            return _produtoSelecionado.precoEstimado * this._quantidade;
        }

        public override string ToString()
        {
            return $"{_produtoSelecionado}: R$ {ObterSubTotalEstimado()}";
        }
    }
}