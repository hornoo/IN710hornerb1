using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class Legfactory : IBodyPartFactory
    {
        //Class to return part of monster required
        public Legfactory()
        {
        }

        public BodyPart requiredpart(int partIndex)
        {
            BodyPart part = null;

            switch (partIndex)
            {
                case 0:
                    part = new BodyPart("images/Fairy_2.png", "Fairy");
                    break;
                case 1:
                    part = new BodyPart("images/Frankenstein_2.png", "Frankenstein");
                    break;
                case 2:
                    part = new BodyPart("images/Skeleton_2.png", "Skeleton");
                    break;
                case 3:
                    part = new BodyPart("images/Vampire_2.png", "Vampire");
                    break;
                case 4:
                    part = new BodyPart("images/Werewolf_2.png", "Werewolf");
                    break;
                case 5:
                    part = new BodyPart("images/Witch_2.png", "Witch");
                    break;
            }

            return part;
        }
    }
}
