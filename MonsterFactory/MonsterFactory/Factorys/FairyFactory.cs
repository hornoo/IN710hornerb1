using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{
    public class FairyFactory : IMonsterFactory
    {
        public FairyFactory()
        {

        }

        public Head getMonsterhead()
        {
            return new FairyHead();
        }

        public Body getMonsterBody()
        {
            return new FairyBody();
        }

        public Legs getMonsterLegs()
        {
            return new FairyLegs();
        }
    }
}
