using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5.Exemplo
{
    public class Engenheiro : Funcionario
    {
        public Engenheiro(string nome, double salario)
        {
            _nome = nome;
            _salario = salario;
        }
        public override double BuscarBonificacao()
        {
            return _salario * 20 / 100;
        }
    }
}
