using System;
using System.Collections;
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
    public partial class ListaCompraForm : Form
    {
        ArrayList _listas = new ArrayList();

        public ListaCompraForm()
        {
            InitializeComponent();
        }

        private void btnNovaListaCompra_Click(object sender, EventArgs e)
        {
            NovaListaComprasForm dialog = new NovaListaComprasForm();
                      
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _listas.Add(dialog.NovaLista);

                AtualizarListasCompras();
            }            
        }

        private void AtualizarListasCompras()
        {
            foreach (ListaCompra lista in _listas)
            {
                if(lista != null)
                    listListaCompras.Items.Add(lista);
            }
        }

      

        private void btnVizualizarListaCompras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chamando visualização de Lista Compras...");
        }
    }
}
