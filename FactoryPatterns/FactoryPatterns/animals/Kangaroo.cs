using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FactoryPatterns
{
    public class Kangaroo : Animal
    {
        public Kangaroo()
        {
            speciesName = "Kangaroo";
            feedingBehaviour = "herbivour";
            mainFoodType = "leafs";
            image = new Bitmap("animalImages/roo.jpg");

        }
    }
}
