using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Character
    {
        protected String charaterName;

        public String StateName()
        {
            return "My name is " + charaterName + "!";
        }

        public abstract String Declaim();
    }
}
