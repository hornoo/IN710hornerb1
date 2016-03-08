using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Character
    {
        protected String characterName;
        protected IWeapon weapon;

        public Character(String characterName)
        {
            this.characterName = characterName;
        }

        public String StateName()
        {
            return "My name is " + characterName + "!";
        }

        public abstract String Declaim();
    }
}
