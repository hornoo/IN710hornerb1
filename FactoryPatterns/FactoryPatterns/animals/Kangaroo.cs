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
        //Set properties of child animal when their construcotr is called.
        public Kangaroo()
        {
            speciesName = "Kangaroo";
            feedingBehaviour = "herbivour";
            mainFoodType = "leafs";
            image = new Bitmap("animalImages/roo.jpg");

        }
    }
}
