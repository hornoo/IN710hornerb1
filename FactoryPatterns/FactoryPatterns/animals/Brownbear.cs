using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public class Brownbear : Animal
    {
        //Set properties of child animal when their construcotr is called.
        public Brownbear() 
        {
            speciesName = "Brown Bear";
            feedingBehaviour = "omnivore";
            mainFoodType = "Moose";
            image = new Bitmap("animalImages/brownbear.jpg");
        }
    }
}
