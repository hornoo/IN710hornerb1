using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public class AustralianAnimalFactory : AnimalFactory
    {

        public AustralianAnimalFactory()
        {
             avaliableAnimalCount = 4;
        }

        //Create animal from index passed in and return
        public override Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Crocodile();
                    break;
                case 1:
                    newAnimal = new Koala();
                    break;
                case 2:
                    newAnimal = new Tasmaniandevil();
                    break;
                case 3:
                    newAnimal = new Kangaroo();
                    break;
            }



            return newAnimal;
        }

    }
}
