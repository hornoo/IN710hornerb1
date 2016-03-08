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
        //protected ListBox gameOutput;
        protected IWeapon weapon{get; set;}
        protected bool isInbattle;

        public Character(String characterName)
        {
            this.characterName = characterName;
            
            this.isInbattle = false;
        }

        public String StateName()
        {
            return "My name is " + characterName + "!";
        }

        public abstract String Declaim();



        public override string ToString()
        {
            return StateName() + " " + Declaim() + " " + weapon.UseWeapon();
        }
    }
}
