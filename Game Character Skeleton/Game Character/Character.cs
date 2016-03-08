using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public abstract class Character
    {
        protected String characterName;
        protected ListBox gameOutput;
        protected IWeapon weapon{get; set;}

        public Character(String characterName, ListBox gameOutput)
        {
            this.characterName = characterName;
            this.gameOutput = gameOutput;
        }

        public String StateName()
        {
            return "My name is " + characterName + "!";
        }

        public abstract String Declaim();
    }
}
