using System;
using System.Collections;

namespace ListaComprasWindowsApp
{
    public class ListaCompra
    {
        public Mes Mes;

        ArrayList _itens = new ArrayList();
      
        public ListaCompra(int numeroMes)
        {
            Mes = new Mes(numeroMes);
        }

        public ListaCompra(Mes mes)
        {
            Mes = mes;
        }

        public decimal ObterTotalEstimado()
        {
            decimal totalEstimado = 0;
            
            foreach (ItemCompra item in _itens)
            {
                decimal subTotal = item.ObterSubTotalEstimado();

                totalEstimado += subTotal;
            }

            return totalEstimado;
        }

        public void Anotar(ItemCompra item)
        {
            _itens.Add(item);
        }

        public ArrayList SelecionarItems()
        {
            return _itens;
        }
        
        public override string ToString()
        {
            return string.Format($"Lista de compras do mês de {Mes} foi gasto R$ {ObterTotalEstimado()} reais");
        }

        
    }
}
