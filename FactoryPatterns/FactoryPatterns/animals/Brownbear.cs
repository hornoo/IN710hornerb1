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
        public Brownbear() 
        {
            speciesName = "Brown Bear";
            feedingBehaviour = "Omnivore";
            mainFoodType = "Moose";
            image = new Bitmap("animalImages/brownbear.jpg");
        }
    }
}
