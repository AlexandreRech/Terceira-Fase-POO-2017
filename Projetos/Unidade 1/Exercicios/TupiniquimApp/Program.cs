using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupiniquimApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            string area = "";
            string posicaoDirecaoRobo = "";
            int posicaoX, posicaoY;
            char direcao = ' ';
            string comando = "";

            Console.WriteLine("Digite a área: ");
            area = Console.ReadLine();

            Console.WriteLine("Digite a posição e a direção do robo");
            posicaoDirecaoRobo = Console.ReadLine();
            string[] arrayPosicaoDirecao = posicaoDirecaoRobo.Split(' ');
            posicaoX = Convert.ToInt32(arrayPosicaoDirecao[0]);
            posicaoY = Convert.ToInt32(arrayPosicaoDirecao[1]);
            direcao = Convert.ToChar(arrayPosicaoDirecao[2]);

            Console.WriteLine("Digite o comando do robo");
            comando = Console.ReadLine();

            char[] instrucoes = comando.ToCharArray();

            foreach (char instrucao in instrucoes)
            {                
                if ( instrucao == 'M') //verificar se é para mover 
                {
                    if (direcao == 'N')
                        posicaoY++;
                  
                    else if (direcao == 'S')
                        posicaoY--;

                    else if (direcao == 'L')
                        posicaoX++;

                    else if (direcao == 'O')
                        posicaoX--;
                }                
                if (instrucao == 'E') //verificar se é para virar esquerda
                {
                    if (direcao == 'N')
                        direcao = 'O';

                    else if (direcao == 'S')
                        direcao = 'L';

                    else if (direcao == 'L')
                        direcao = 'N';

                    else if (direcao == 'O')
                        direcao = 'S';
                }
                if (instrucao == 'D') //verificar se é para virar esquerda
                {
                    if (direcao == 'N')
                        direcao = 'L';

                    else if (direcao == 'S')
                        direcao = 'O';

                    else if (direcao == 'L')
                        direcao = 'S';

                    else if (direcao == 'O')
                        direcao = 'N';
                }
            }

            Console.WriteLine(posicaoX + " " + posicaoY + " " + direcao );

            Console.ReadKey();
        }
    }
}
