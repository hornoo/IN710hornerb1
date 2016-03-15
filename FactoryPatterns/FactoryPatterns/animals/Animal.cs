using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPatterns
{
    public abstract class Animal
    {
        protected String speciesName;
        protected String feedingBehaviour;
        protected String mainFoodType;
        protected Bitmap image;

        public Bitmap Image { get { return image; } }

        public override string ToString()
        {
            String returnString = "I'm " + speciesName + ".";
            returnString += " I am a " + feedingBehaviour + ".";
            returnString += " I eat " + mainFoodType + ".";

            return returnString;
        }
    }
}
