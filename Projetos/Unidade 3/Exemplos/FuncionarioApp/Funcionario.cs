using System;

namespace FuncionarioApp
{
    public class Funcionario
    {
        public string nome = "";
        public double salario = 1000;
        public Data dataEntrada;

        public bool estaTrabalhando = true;
        public bool estaDemitido;
      

        public bool EstaTrabalhando()
        {
            return estaTrabalhando;
        }

        public void Demitir()
        {
            estaDemitido = true;
            estaTrabalhando = false;
        }

        public void Bonificar(double quantia)
        {
            salario += quantia;
        }

        public string MostrarDados()
        {
            return string.Format(
                "O funcionario {0} com salario {2} {1} está trabalhando",
                this.nome,
                this.EstaTrabalhando() ? "" : "não",
                this.salario);
        }

       
    }
}