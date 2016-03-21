using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class HeadFactory : IBodyPartFactory
    {//Class to return part of monster required
        public HeadFactory()
        {
        }

        public BodyPart requiredpart(int partIndex)
        {
            BodyPart part = null;

            switch (partIndex)
            {
                case 0:
                    part = new BodyPart("images/Fairy_0.png", "Fairy");
                    break;
                case 1:
                    part = new BodyPart("images/Frankenstein_0.png", "Frankenstein");
                    break;
                case 2:
                    part = new BodyPart("images/Skeleton_0.png", "Skeleton");
                    break;
                case 3:
                    part = new BodyPart("images/Vampire_0.png", "Vampire");
                    break;
                case 4:
                    part = new BodyPart("images/Werewolf_0.png", "Werewolf");
                    break;
                case 5:
                    part = new BodyPart("images/Witch_0.png", "Witch");
                    break;
            }

            return part;
        }
    }
}
