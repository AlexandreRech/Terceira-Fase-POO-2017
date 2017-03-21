using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupiniquimApp
{
    public class Robo
    {
        public char direcao;
        public int posicaoY;
        public int posicaoX;

        public void Explorar(string comando) //EMEMEMEMM
        {
            char[] instrucoes = comando.ToCharArray();

            foreach (char instrucao in instrucoes)
            {
                if (instrucao == 'M')                 
                    Mover();
                
                if (instrucao == 'E')                 
                    VirarEsquerda();
                
                if (instrucao == 'D')                
                    VirarDireita();               
            }
        }

        public string ObtemPosicaoFinal()
        {
            return posicaoX + " " + posicaoY + " " + direcao;
        }

        private void VirarDireita()
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

        private void VirarEsquerda()
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

        private void Mover()
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

    }

}
