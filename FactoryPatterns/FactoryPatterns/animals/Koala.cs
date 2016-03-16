using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public class Koala : Animal
    {
        //Set properties of child animal when their construcotr is called.
        public Koala()
        {
            speciesName = "Koala";
            feedingBehaviour = "herbivor";
            mainFoodType = "leafs";
            image = new Bitmap("animalImages/koala.jpg");
        }
    }
}
