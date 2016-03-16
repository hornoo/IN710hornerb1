using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns.animals
{
    class Tasmaniandevil : Animal
    {
        public Tasmaniandevil()
        {
            speciesName = "Tasmanian Devil";
            feedingBehaviour = "Carnivore";
            mainFoodType = "Snakes";
            image = new Bitmap("animalImages/taz.jpg");
        }
    }
}
