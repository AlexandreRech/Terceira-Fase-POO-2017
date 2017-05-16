namespace Unidade6.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Gerente();
            funcionario1.Nome = "Angela de Liz";
            funcionario1.Salario = 10000;

            Funcionario funcionario2 = new Diretor();
            funcionario2.Nome = "Roger Motta";
            funcionario2.Salario = 10000;            

            Funcionario funcionario3 = new Presidente();
            funcionario3.Salario = 20000;

            Funcionario funcionario4 = new AnalistaNegocio();
            funcionario4.Salario = 5000;
                        

            ControladorBonificacao controlador = new ControladorBonificacao();

            controlador.RegistrarBonificao(funcionario1);
            controlador.RegistrarBonificao(funcionario2);
            controlador.RegistrarBonificao(funcionario3);
            controlador.RegistrarBonificao(funcionario4);

            System.Console.WriteLine(controlador.ValorTotalBonificacao);

            System.Console.ReadLine();
        }
    }
}
