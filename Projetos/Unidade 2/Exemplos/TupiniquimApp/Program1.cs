using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupiniquimApp
{
    class Program1
    {
        static void Main1(string[] args)
        {
            
            Robo robocop = new Robo();
            robocop.posicaoX = 1;
            robocop.posicaoY = 2;
            robocop.direcao = 'N';

            robocop.Explorar("EMEMEMEMM");

            string posicaoFinalRobocop = robocop.ObtemPosicaoFinal();

            Console.WriteLine( posicaoFinalRobocop );

            Robo wall_e = new Robo();
            wall_e.posicaoX = 3;
            wall_e.posicaoY = 3;
            wall_e.direcao = 'L';

            wall_e.Explorar("MMDMMDMDDM");

            Console.WriteLine(wall_e.ObtemPosicaoFinal());

            Console.ReadKey();
        }
    }
}
