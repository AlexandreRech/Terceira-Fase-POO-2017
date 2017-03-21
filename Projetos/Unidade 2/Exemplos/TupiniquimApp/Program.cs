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
            Robo robocop = new Robo();
            robocop.posicaoX = 10;

            Robo rosie = new Robo();
            rosie.posicaoX = 20;

            Robo exterminadorDoFuturo = new Robo();
            exterminadorDoFuturo.posicaoX = 30;

            robocop.posicaoX = 40;
        }
    }
}
