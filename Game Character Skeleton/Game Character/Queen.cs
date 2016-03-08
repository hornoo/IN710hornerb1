using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Queen : Character
    {

        public Queen(String characterName)
            : base(characterName)
        {
            weapon = new Bow();
        }
        public override string Declaim()
        {
            return "I am the powerful Queen!";
        }

    }
}
