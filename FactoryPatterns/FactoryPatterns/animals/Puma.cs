﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public class Puma : Animal
    {
        //Set properties of child animal when their construcotr is called.
        public Puma()
        {
            speciesName = "Puma";
            feedingBehaviour = "carnivore";
            mainFoodType = "Deer";
            image = new Bitmap("animalImages/puma.jpg");
        }
    }
}
