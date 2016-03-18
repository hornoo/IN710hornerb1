using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GameCompFactory : IComputerfactory
    {
        public CPU makeCpu()
        {
            return new GamingCPU();
        }

        public GPU makeGPU()
        {
            return new GamingGPU();
        }

        public RAM makeRAM()
        {
            return new 
        }
    }
}
