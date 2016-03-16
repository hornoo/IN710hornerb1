using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryPatterns
{
    public class NorthAmerica : Continent
    {

        public NorthAmerica(int nAnimalTypes, Random r)
            : base(r, nAnimalTypes)
        {
            animalFactory = new NorthAmericaAnimalFactory();
        }

    }
}
