using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListaComprasWindowsApp
{
    public class ListaCompra
    {
        public Mes Mes;
        
        List<ItemCompra> _itens = new List<ItemCompra>();
      
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

        public List<ItemCompra> SelecionarItems()
        {
            return _itens;
        }
        
        public override string ToString()
        {
            return string.Format($"Lista de compras do mês de {Mes} foi gasto R$ {ObterTotalEstimado()} reais");
        }

        
    }
}
