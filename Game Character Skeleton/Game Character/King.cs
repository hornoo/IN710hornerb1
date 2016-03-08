using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class King : Character
    {
        public King(String characterName, ListBox gameOutput)
            : base(characterName, gameOutput)
        {
            weapon = new Sword();
        }
        public override string Declaim()
        {
            return "I am the most mighty King!";
        } 


    }
}
