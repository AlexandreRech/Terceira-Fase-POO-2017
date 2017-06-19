using System;

namespace ListaComprasWindowsApp
{
    public class ListaCompra
    {
        public Mes Mes;

        private ItemCompra[] _itens = new ItemCompra[10];
      
        public ListaCompra(int numeroMes)
        {
            Mes = new Mes(numeroMes);
        }

        public ListaCompra(Mes mes)
        {
            Mes = mes;
        }

        public double ObterTotalEstimado()
        {
            double totalEstimado = 0;
            
            foreach (ItemCompra item in _itens)
            {
                if (item == null)
                    continue;

                double subTotal = item.ObterSubTotalEstimado();

                totalEstimado += subTotal;
            }

            return totalEstimado;
        }

        public void Anotar(Produto produto, int quantidade)
        {
            ItemCompra item = new ItemCompra(produto, quantidade);

            Anotar(item);
        }

        public void Anotar(ItemCompra item)
        {
            int posicaoVazia = Array.IndexOf(_itens, null);

            _itens[posicaoVazia] = item;
        }

        public ItemCompra[] SelecionarItems()
        {
            ItemCompra[] itens = new ItemCompra[QuantidadeItens()];

            Array.Copy(_itens, itens, QuantidadeItens());
                
            return itens;
        }
        
        public override string ToString()
        {
            return string.Format($"Lista de compras do mês de {Mes} foi gasto R$ {ObterTotalEstimado()} reais");
        }

        private int QuantidadeItens()
        {
            int qtdItens = 0;

            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                    qtdItens++;
            }

            return qtdItens;
        }
    }
}
