using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    using global::Exemplo1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Exemplo1
    {
        public class Passaro : IAnimal
        {
            public void SomAnimal()
            {
                Console.WriteLine("Pru pru...");
            }

            public void Brincar()
            {
                Console.WriteLine("Brincando de voar...");
            }

            public void Comer()
            {
                Console.WriteLine("Comendo uma semente...");
            }
        }
    }

}
