using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    class Tasmaniandevil : Animal
    {
        //Set properties of child animal when their construcotr is called.
        public Tasmaniandevil()
        {
            speciesName = "Tasmanian Devil";
            feedingBehaviour = "carnivore";
            mainFoodType = "snakes";
            image = new Bitmap("animalImages/taz.jpg");
        }
    }
}
