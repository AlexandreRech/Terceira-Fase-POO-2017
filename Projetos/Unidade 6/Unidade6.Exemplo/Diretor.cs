namespace Unidade6.Exemplo
{
    public class Diretor : Funcionario
    {
        public override double BuscarBonificacao()
        {
            return Salario * 0.20;
        }
    }
}