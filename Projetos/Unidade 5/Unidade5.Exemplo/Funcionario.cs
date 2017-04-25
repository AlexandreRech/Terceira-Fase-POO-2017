using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5.Exemplo
{
    public class Funcionario : Pessoa
    {
        private string _cpf;
        protected double _salario;

        public Funcionario() { }

        public Funcionario(string nome, double salario)
        {
            if (nome == "")
                _nome = "Nome não informado";
            else
                _nome = nome;

            if (salario > 0)
                _salario = salario;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public virtual double BuscarBonificacao()
        {
            return _salario * 10 / 100;
        }

        public override string ToString()
        {
            string informacoes = "";

            informacoes += "Nome do Funcionário: " + _nome ;
            informacoes += " - Salário do Funcionário: " + _salario ;

            return informacoes;
        }

       
    }
}
