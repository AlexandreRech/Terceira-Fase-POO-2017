namespace Unidade6.Exemplo
{
    public class Gerente : Funcionario
    {
        public override double BuscarBonificacao()
        {
            return Salario * 0.15;
        }

        public override string ToString()
        {
            return Nome + " - " + Salario;
        }

    }
}