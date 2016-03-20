using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    
    public abstract class BodyPart
    {

        protected String pathToImage;
        

        public String getImage()
        {
            return pathToImage;
        }
    }
}
