using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5.Exemplo
{
    public class Gerente : Funcionario
    {
        private string _senha;

        public Gerente(string nome)
        {
            if (nome == "")
                _nome = "Nome não informado";
            else
                _nome = nome;
        }

        public Gerente(string nome, string senha)
        {
            if (nome == "")
                _nome = "Nome não informado";
            else
                _nome = nome;

            _senha = senha;
        }

        public string Autenticar(string senha)
        {
            if (_senha == senha)
                return "O usuário " + _nome + " foi autenticado" ;
            else
                return "O usuário " + _nome + " não foi autenticado";
        }
    }
}
