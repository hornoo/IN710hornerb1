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
            Body body = null;

            switch(partIndex)
            {
                case 0:
                    body = new FairyBody();
                    break;
                case 1:
                    body = new FrankBody();
                    break;
            }

            return body;
        }
    }
}
