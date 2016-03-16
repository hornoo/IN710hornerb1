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
       //Set properties of child animal when their construcotr is called.
       public Bison()
       {
           speciesName = "Bison";
           feedingBehaviour = "herbivour";
           mainFoodType = "Grass";
           image = new Bitmap("animalImages/bison.jpg");
       }
    }
}
