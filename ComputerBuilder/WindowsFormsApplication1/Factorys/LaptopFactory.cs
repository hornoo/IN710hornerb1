using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LaptopFactory : IComputerfactory
    {
        public CPU makeCpu()
        {
            return new LaptopCPU();
        }

        public GPU makeGPU()
        {
            return new LaptopGPU();
        }

        public RAM makeRAM()
        {
            return new LaptopRAM();
        }

        public PowerSupply makePSU()
        {
            return new LaptopPSU();
        }
    }
}
