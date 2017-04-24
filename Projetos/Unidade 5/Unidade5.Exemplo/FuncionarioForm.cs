using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidade5.Exemplo
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario novoFuncionario = new Funcionario("");

            MessageBox.Show("Funcionario " + novoFuncionario.Nome 
                + " cadastrado com sucesso" );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerente novoFuncionario = new Gerente("Flávio", "123");
            
            MessageBox.Show(novoFuncionario.Autenticar("123"));
        }
    }
}
