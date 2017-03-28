using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionarioApp
{
    public partial class FuncionarioForm : Form
    {
        public Funcionario funcionario;

        public FuncionarioForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {             
            double valor = double.Parse( textBox4.Text );

            funcionario.Bonificar(valor);

            richTextBox1.Text = funcionario.MostrarDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();

            funcionario.nome = textBox1.Text;
            funcionario.salario = double.Parse(textBox2.Text);

            string[] strData = textBox3.Text.Split('/');

            Data hoje = new Data();
            hoje.dia = int.Parse(strData[0]);
            hoje.mes = int.Parse(strData[1]);
            hoje.ano = int.Parse(strData[2]);

            funcionario.dataEntrada = hoje;

            richTextBox1.Text = funcionario.MostrarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionario.Demitir();

            richTextBox1.Text = funcionario.MostrarDados();
        }
    }
}
