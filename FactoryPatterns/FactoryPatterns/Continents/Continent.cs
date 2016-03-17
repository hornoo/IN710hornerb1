using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public abstract class Continent
    {
        //Defaul mout of animals to prin to the screen
        public const int ANIMA_SIML_COUNT = 5;

        //Parent fields used in oprent class
        //Random required to pick animas reandomly from the Ianimalfactory.
        protected Random r;
        //Number of different animasl avalaiable for creationfrom animal factory
        protected int nAnimalTypes;

        //Animal factory to take care of creating animals
        protected AnimalFactory animalFactory;


        //Constructor requires reference to a random int gen and how many animals types are avaliable, the avaliable types are set in the child class constructor.
        public Continent(Random r)
        {
            this.r = r; 
        }

        //Generate require abount of animals randomly and return as a list of animal objects.
        public List<Animal> runSim()
        {
            //List of animals to return.
            List<Animal> returnListAnimals = new List<Animal>();

            //For the amount of animals required
            for (int i = 0; i < ANIMA_SIML_COUNT; i++ )
            {
                //Generate an random int to be used as an index of what animal is created from the count of avaliable animal types.
                int animalFactorAnimalIndex = r.Next(nAnimalTypes);
                //Generate animal awith factory and add returned animal to lost that will be returned
                returnListAnimals.Add(animalFactory.createAnimal(animalFactorAnimalIndex));
            }

                return returnListAnimals;

        }
   
    }
}
