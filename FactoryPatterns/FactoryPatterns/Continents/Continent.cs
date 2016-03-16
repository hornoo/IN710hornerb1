using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public abstract class Continent
    {
        public const int ANIMA_SIML_COUNT = 4;

        protected Random r;
        protected int nAnimalTypes;
        protected IAnimalFactory animalFactory;

        public Continent(Random r, int nAnimalTypes)
        {
            this.r = r;
            this.nAnimalTypes = nAnimalTypes;
        }

        public List<Animal> runSim()
        {
            List<Animal> returnListAnimals = new List<Animal>();

            Animal newAnimal = null;

            for (int i = 0; i < ANIMA_SIML_COUNT; i++ )
            {
                int animalFactorAnimalIndex = r.Next(nAnimalTypes - 1);
                newAnimal = animalFactory.createAnimal(animalFactorAnimalIndex);
                returnListAnimals.Add(newAnimal);
            }

                return returnListAnimals;

        }
   
    }
}
