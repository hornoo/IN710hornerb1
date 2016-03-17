using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    public class AnimalFactory
    {
        //Interface to set required methods for animal factorys.
       
        Animal createAnimal(int animalCode);
        int AvaliableAnimalCount();
    }
}
