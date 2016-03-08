using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Knight : Character
    {

        public Knight(String characterName):base(characterName)
        {
            weapon = new Knife();
        }

        public override string Declaim()
        {
            return "I am a chivalrous Knight!";
        }
    }
}
