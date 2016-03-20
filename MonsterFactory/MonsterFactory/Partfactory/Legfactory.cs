using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class Legfactory : IBodyPartFactory
    {
        public Legfactory()
        {
        }

        public BodyPart requiredpart(int partIndex)
        {
            BodyPart leg = null;

            switch (partIndex)
            {
                case 0:
                    leg = new FairyLegs();
                    break;
                case 1:
                    leg = new FrankLegs();
                    break;
            }

            return leg;
        }
    }
}
