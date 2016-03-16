using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
   public class Bison : Animal
    {
       public Bison()
       {
           speciesName = "Bison";
           feedingBehaviour = "herbivour";
           mainFoodType = "Grass";
           image = new Bitmap("animalImages/bison.jpg");
       }
    }
}
