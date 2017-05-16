using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidade7.Exemplo
{
    public partial class Form1 : Form
    {
        private ContaCorrente conta;

        public Form1()
        {
            InitializeComponent();
            double saldoInicial = double.Parse(txtSaldo.Text);
            conta = new ContaCorrente(saldoInicial);
        }

        private void btnTestarExceptions_Click(object sender, EventArgs e)
        {
            listLog.Items.Add("Início do Método Click");
            Metodo1();
            listLog.Items.Add("Fim do Método Click");
        }

        private void Metodo1()
        {
            listLog.Items.Add("Início do Método 1");
            Metodo2();
            listLog.Items.Add("Fim do Método 1");
        }

        private void Metodo2()
        {
            listLog.Items.Add("Início do Método 2");

            int[] array = new int[10];

            try
            {
                for (int i = 0; i < 15; i++)
                {
                    array[i] = i + 1;
                    listLog.Items.Add(array[i]);
                }
            }
            catch(IndexOutOfRangeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            listLog.Items.Add("Fim do Método 2");
        }

        private void btnCarregarArquivo_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = txtCaminhoArquivo.Text;

            string conteudoArquivo = "";
            try
            {
                conteudoArquivo = File.ReadAllText(caminhoArquivo);
            }           
            catch (ArgumentException)
            {
                MessageBox.Show("Caminho em branco");
            }            
            catch (FileNotFoundException)
            {
                MessageBox.Show("Caminho inválido");
            }

            txtConteudoArquivo.Text = conteudoArquivo;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conta.Sacar(double.Parse(txtSaque.Text));
                txtSaldo.Text = conta.Saldo.ToString();
            }
            catch (SaldoInsuficienteException sie)
            {
                MessageBox.Show(sie.Message);
            }                      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conta.Depositar(double.Parse(txtDeposito.Text));
            txtSaldo.Text = conta.Saldo.ToString();
        }
    }
}
