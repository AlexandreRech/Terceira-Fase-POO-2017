namespace Unidade6.Exemplo
{
    public abstract class Funcionario : object
    {
        public string Nome { get; set; }

        public  double Salario { get; set; }

        public abstract double BuscarBonificacao();
    }
}