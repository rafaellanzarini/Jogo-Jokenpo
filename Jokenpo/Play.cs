using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    class Play
    {

        public string RetornaTextoVencedor(int res)
        {
            if ((res == -1) || (res == 2))
            {
                return "Vencedor é Jogador";
                
            }
            else
            {
                return "Vencedor é IA";
               
            }
        }

        public int retornapontosjogador(int res, int pontos)
        {
            //int pontosJogador = 0;//pontosIA = 0, numIA;
            
            if ((res == -1) || (res == 2))
            {               
                pontos++;

            }
            return pontos;
        }
        
        public int retornapontosia(int res, int pontos)
        {
            if ((res == 1) || (res == -2))
            {
                pontos++;
            }
            return pontos;
        }
    }
}
