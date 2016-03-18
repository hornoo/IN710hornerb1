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
            throw new NotImplementedException();
        }

        public GPU makeGPU()
        {
            throw new NotImplementedException();
        }

        public RAM makeRAM()
        {
            throw new NotImplementedException();
        }
    }
}
