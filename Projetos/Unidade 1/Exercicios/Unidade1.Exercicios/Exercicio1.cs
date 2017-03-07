using System;

namespace Unidade1.Exercicios
{
    class Exercicio1
    {
        /* 
         1)     Calcular o volume de uma caixa retangular
                Calcula o volume da caixa retangular
                (volume = comprimento * largura * altura;)
         */

        static void Main1(string[] args)
        {
            double volume = 0;

            Console.WriteLine("Digite o comprimento da caixa: ");

            string sComprimento = Console.ReadLine();

            double comprimento = Convert.ToDouble(sComprimento);

            Console.WriteLine("Digite a largura da caixa: ");

            string sLargura = Console.ReadLine();

            double largura = Convert.ToDouble(sLargura);

            Console.WriteLine("Digite a altura da caixa: ");

            string sAltura = Console.ReadLine();

            double altura = Convert.ToDouble(sAltura);

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume);

            Console.ReadKey();

        }
    }
}
