using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Knight : Character
    {
        //Child of charater class, when instantiated a default weapon is set forht type of charater
        public Knight(String characterName)
            : base(characterName)
        {
            weapon = new Knife();
        }

        //override method of parent abstart method
        public override string Declaim()
        {
            return "I am a chivalrous Knight!";
        }
    }
}
