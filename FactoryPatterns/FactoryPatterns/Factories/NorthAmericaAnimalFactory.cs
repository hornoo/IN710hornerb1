using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public class NorthAmericaAnimalFactory : AnimalFactory
    {
        //Amount of avaliable animals
        const int avaliableAnimalCount = 4;

        public NorthAmericaAnimalFactory()
        {
            
        }

        //Create animal from index passed in and return
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
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
                case 3:
                    newAnimal = new Bison();
                    break;
            }

            return newAnimal;
        }

        //return amount of avaliable animals
        public int AvaliableAnimalCount()
        {
            return avaliableAnimalCount;
        }
    }
}
