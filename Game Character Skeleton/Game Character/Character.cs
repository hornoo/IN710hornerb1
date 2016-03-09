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
        public String characterName { get; set; }
        //protected ListBox gameOutput;
        public IWeapon weapon{get; set;}
        public bool isInbattle{get; set;}

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
