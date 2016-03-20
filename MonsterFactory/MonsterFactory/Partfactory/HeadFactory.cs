using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class HeadFactory : IBodyPartFactory
    {
        public HeadFactory()
        {
        }

        public BodyPart requiredpart(int partIndex)
        {
            BodyPart head = null;

            switch (partIndex)
            {
                case 0:
                    head = new FairyHead();
                    break;
                case 1:
                    head = new FrankHead();
                    break;
            }

            return head;
        }
    }
}
