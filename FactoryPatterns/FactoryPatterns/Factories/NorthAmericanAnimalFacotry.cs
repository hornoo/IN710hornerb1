using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns.Factories
{
    class NorthAmericanAnimalFacotry : IAnimalFactory
    {

        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch(animalCode)
            {
                case 0:
                    newAnimal = new Armadillo();
                    break;
                case 1:
                    newAnimal = new Brownbear();
                    break;
                case 2:
                    newAnimal = new Puma();
                    break;
            }

            return newAnimal;
        }
    }
}
