﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaComprasWindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region exemplo utilizando ConsoleApp
            //int janeiro = 1;

            //ListaCompra listaJaneiro = new ListaCompra(janeiro);

            //listaJaneiro.Anotar(new Produto("CERVEJA", 10, "CX"), 2);
            //listaJaneiro.Anotar(new Produto("PICANHA", 30, "KG"), 3);
            //listaJaneiro.Anotar(new Produto("CARVÃO", 10, "PCT"), 1);

            //double totalEstimadoJaneiro = listaJaneiro.ObterTotalEstimado();

            //int fevereiro = 2;

            //ListaCompra listaFevereiro = new ListaCompra(fevereiro);

            //listaFevereiro.Anotar(new Produto("CERVEJA", 20, "CX"), 1);
            //listaFevereiro.Anotar(new Produto("PICANHA", 20, "KG"), 1);
            //listaFevereiro.Anotar(new Produto("CARVÃO", 10, "PCT"), 1);

            //double totalEstimadoFevereiro = listaFevereiro.ObterTotalEstimado();

            //Console.WriteLine(totalEstimadoJaneiro);
            //Console.WriteLine(totalEstimadoFevereiro);

            //Console.ReadKey();
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListaCompraForm());
        }
    }
}
