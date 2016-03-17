using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public abstract class AnimalFactory
    {

        protected int avaliableAnimalCount;

        public int AvaliableAnimalCount
        {
            get { return avaliableAnimalCount;  }
        }
       
        public abstract Animal createAnimal(int animalCode);

    }
}
