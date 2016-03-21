using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory
{//Class of a monster made up of varous parts passed in
    public class MonsterBuilder
    {
        public BodyPart monsterHead { get; set;}
        public BodyPart monsterBody { get; set; }
        public BodyPart monsterLegs { get; set; }

        public MonsterBuilder(BodyPart head, BodyPart body, BodyPart legs)
        {
            monsterHead = head;
            monsterBody = body;
            monsterLegs = legs;
        }

        //return selected parts when required
        public String headpicture()
        {
            return monsterHead.getImage();
        }

        public String bodyPictur()
        {
            return monsterBody.getImage();
        }

        public String legPicture()
        {
            return monsterLegs.getImage();
        }


    }
}
