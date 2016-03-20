using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MultimediaCompFactory : IComputerfactory
    {
        public CPU makeCpu()
        {
            return new MultimediaCPU();
        }

        public GPU makeGPU()
        {
            return new MultimediaGPU();
        }

        public RAM makeRAM()
        {
            return new MultimediaRAM();
        }

        public PowerSupply makePSU()
        {
            return new MultimediaPSU();
        }
    }
}
