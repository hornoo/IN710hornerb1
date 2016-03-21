using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface IComputerfactory
    {//interface for a computer factory, required methods
        CPU makeCpu();
        GPU makeGPU();
        RAM makeRAM();
        PowerSupply makePSU();
    }
}
