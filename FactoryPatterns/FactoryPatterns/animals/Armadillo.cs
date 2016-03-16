using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public class Armadillo : Animal
    {
        public Armadillo()
        {
            speciesName = "Armadillo";
            feedingBehaviour = "omnivore";
            mainFoodType = "insects";
            image = new Bitmap("animalImages/armadillo.jpg");
        }
    }
}
