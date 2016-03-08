using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Troll : Character
    {

        public Troll(String characterName):base(characterName)
        {
            weapon = new Bow();
        }
        public override string Declaim()
        {
            return "Trolls don't have time to chat!";    
        }
    }
}
