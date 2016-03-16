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
        //Set properties of child animal when their construcotr is called.
        public Crocodile()
        {
            speciesName = "Crocodile";
            feedingBehaviour = "carnivore";
            mainFoodType = "any small animal";
            image = new Bitmap("animalImages/crock.jpg");
        }

    }
}
