using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unidade4.Exemplos
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            _nome = nome;
        }

        public string _nome;
        public string _sobreNome;

       public string NomeCompleto
        {
            get
            {
                return _nome + " " + _sobreNome;
            }
        }
        
    }
}
