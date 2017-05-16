using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidade7.Exemplo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ContaCorrente conta = new ContaCorrente(1000);
            //try
            //{
            //    conta.Sacar(1200);
            //}
            //catch (SaldoInsuficienteException sie)
            //{
            //    Console.WriteLine(sie.Message);                
            //}

            //Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
