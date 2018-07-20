using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    class IA
    {
      Random numero = new Random();

        public string EscolhaTextoIA(int escolha)
        {
            if (escolha == 1)
            {
                return "IA: papel";
            }
            else if(escolha == 2)
            {
                return "IA: pedra";
            }
            else
            {
                return "IA: tesoura";
            }
        }

        public int EscolhaIndexIA()
        {
            return numero.Next(1, 4);
        }
    }
}
