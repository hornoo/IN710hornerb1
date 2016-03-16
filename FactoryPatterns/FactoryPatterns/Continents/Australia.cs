using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    class Australia : Continent
    {
                public Australia(int nAnimalTypes, Random r)
            : base(r, nAnimalTypes)
        {
            animalFactory = new AustralianAnimalFactory();
        }

    }
}
