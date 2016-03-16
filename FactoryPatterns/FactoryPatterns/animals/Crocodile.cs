using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public class Crocodile : Animal
    {
        public Crocodile()
        {
            speciesName = "Crocodile";
            feedingBehaviour = "carnivore";
            mainFoodType = "any small animal";
            image = new Bitmap("animalImages/crock.jpg");
        }

    }
}
