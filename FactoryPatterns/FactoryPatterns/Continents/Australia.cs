using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    class Australia : Continent
    {

        public Australia(Random r)
            : base(r)
        {
            animalFactory = new AustralianAnimalFactory();
            nAnimalTypes = animalFactory.AvaliableAnimalCount();
        }

    }
}
