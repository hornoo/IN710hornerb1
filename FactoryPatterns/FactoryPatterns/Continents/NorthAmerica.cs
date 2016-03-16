using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryPatterns
{
    public class NorthAmerica : Continent
    {
        
        public NorthAmerica(Random r)
            : base(r)
        {
            animalFactory = new NorthAmericaAnimalFactory();
            nAnimalTypes = animalFactory.AvaliableAnimalCount();
        }

    }
}
