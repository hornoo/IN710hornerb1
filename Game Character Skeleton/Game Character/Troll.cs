using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Troll : Character
    {
        //Child of charater class, when instantiated a default weapon is set forht type of charater
        public Troll(String characterName)
            : base(characterName)
        {
            weapon = new Bow();
        }
        //override method of parent abstart method
        public override string Declaim()
        {
            return "Trolls don't have time to chat!";    
        }
    }
}
