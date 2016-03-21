using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    
    public class BodyPart
    {
        // Class than can be set to any type of body part
        protected String pathToImage;
        protected String monsterType;

        public BodyPart(String imagePath, String MonsterLabel)
        {
            pathToImage = imagePath;
            monsterType = MonsterLabel;
        }
        
        

        public String getImage()
        {
            return pathToImage;
        }
    }
}
