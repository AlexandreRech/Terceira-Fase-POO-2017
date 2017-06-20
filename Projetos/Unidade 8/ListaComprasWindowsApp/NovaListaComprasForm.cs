using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaComprasWindowsApp
{
    public partial class NovaListaComprasForm : Form
    {
        private ListaCompra _novaLista;

        public NovaListaComprasForm()
        {
            InitializeComponent();

            CarregarMeses();
        }

        public ListaCompra NovaLista
        {
            get
            {
                return _novaLista;
            }
        }

        private void CarregarMeses()
        {
            for (int numero = 1; numero <= 12; numero++)
            {
                cmbMes.Items.Add(new Mes(numero));
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtProduto.Text;
            decimal preco = decimal.Parse(txtPreco.Text);
            string unidade = cmbUnidade.Text;

            Produto produto = new Produto(nome, preco, unidade);

            decimal quantidade = txtQuantidade.Value;

            ItemCompra item = new ItemCompra(produto, quantidade);

            listItensCompra.Items.Add(item);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Mes mesSelecionado = (Mes)cmbMes.SelectedItem;

            _novaLista = new ListaCompra(1);

            foreach (ItemCompra item in listItensCompra.Items)
            {
                _novaLista.Anotar(item);
            }
        }
    }
}
