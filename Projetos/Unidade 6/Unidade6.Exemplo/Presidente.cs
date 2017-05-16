namespace Unidade6.Exemplo
{
    public class Presidente : Funcionario
    {
        public override double BuscarBonificacao()
        {
            return Salario * 0.50;
        }
    }
}