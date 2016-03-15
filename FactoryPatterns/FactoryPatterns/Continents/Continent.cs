using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public abstract class Continent
    {
        public const int ANIMA_SIM_COUNT = 4;

        protected Random r;
        protected int nAnimalTypes;
        protected IAnimalFactory animalFactory;

        public Continent(Random r, int nAnimalTypes)
        {
            this.r = r;
            this.nAnimalTypes = nAnimalTypes;
        }

        public abstract override string ToString();
   
    }
}
