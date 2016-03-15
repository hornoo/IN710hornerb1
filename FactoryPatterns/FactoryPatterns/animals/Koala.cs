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
        public Koala()
        {
            speciesName = "Koala";
            feedingBehaviour = "Herbivor";
            mainFoodType = "Leafs";
            image = new Bitmap("animalImages/koala");
        }
    }
}
