using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class FrankensteinFactory : IMonsterFactory
    {
        public FrankensteinFactory()
        {

        }

        public Head getMonsterhead()
        {
            return new FrankHead();
        }

        public Body getMonsterBody()
        {
            return new FrankBody();
        }

        public Legs getMonsterLegs()
        {
            return new FrankLegs();
        }
    }
}
