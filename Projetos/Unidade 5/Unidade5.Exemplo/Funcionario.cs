using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5.Exemplo
{
    public class Funcionario
    {
        protected string _nome;
        private string _cpf;
        private double _salario;

        public Funcionario() { }

        public Funcionario(string nome)
        {
            if (nome == "")
                _nome = "Nome não informado";
            else
                _nome = nome;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }
    }
}
