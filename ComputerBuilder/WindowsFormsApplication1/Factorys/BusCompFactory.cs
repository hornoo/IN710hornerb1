using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BusCompFactory : IComputerfactory
    {
        public CPU makeCpu()
        {
            return new BusinessCPU();
        }

        public GPU makeGPU()
        {
            return new BusinessGPU();
        }

        public RAM makeRAM()
        {
            return new BusinessRAM();
        }

        public PowerSupply makePSU()
        {
            return new BusinnesPSU();
        }
    }
}
