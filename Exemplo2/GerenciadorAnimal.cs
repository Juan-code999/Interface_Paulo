using Exemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    public class GerenciadorAnimal
    {
        public void RealizarAcao(IAnimal animal)
        {
            animal.SomAnimal();
            animal.Comer();
            animal.Brincar();
        }
    }
}
