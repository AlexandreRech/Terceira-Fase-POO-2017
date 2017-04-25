using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidade5.Exemplo
{
    public partial class FuncionarioForm : Form
    {
        Funcionario funcionario = null;

        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            double salario = double.Parse(txtSalario.Text);

            if (rdbComum.Checked)
                funcionario = new Funcionario(nome, salario);

            else if (rdbGerente.Checked)
                funcionario = new Gerente(nome, salario);

            else if (rdbEngenheiro.Checked)
                funcionario = new Engenheiro(nome, salario);

            listFuncionarios.Items.Add(funcionario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerente novoFuncionario = new Gerente("Flávio", "123");
            
            MessageBox.Show(novoFuncionario.Autenticar("123"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioSelecionado = (Funcionario)listFuncionarios.SelectedItem;

            MessageBox.Show("O Bônus do " + funcionarioSelecionado.Nome + " é: "
                + funcionarioSelecionado.BuscarBonificacao());
        }
    }
}
