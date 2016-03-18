using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class ComputerComponent
    {
        public String componentName;
        public int componentPrice;

        public String Componentname
        {
            get {return componentName;}
        }

        public int ComponentPrice
        {
            get { return componentPrice; }
        }


    }
}
