using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class BodyFactory : IBodyPartFactory
    {
        public BodyFactory()
        {

        }

        public BodyPart requiredpart(int partIndex)
        {
            BodyPart part = null;

            switch(partIndex)
            {
                case 0:
                    part = new BodyPart("images/Fairy_1.png", "Fairy");
                    break;
                case 1:
                    part = new BodyPart("images/Frankenstein_1.png", "Frankenstein");
                    break;
                case 2:
                    part = new BodyPart("images/Skeleton_1.png", "Skeleton");
                    break;
                case 3:
                    part = new BodyPart("images/Vampire_1.png", "Vampire");
                    break;
                case 4:
                    part = new BodyPart("images/Werewolf_1.png", "Werewolf");
                    break;
                case 5 :
                    part = new BodyPart("images/witch_1.png", "Witch");
                    break;
            }

            return part;
        }
    }
}
