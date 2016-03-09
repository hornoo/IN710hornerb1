using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Bow : IWeapon
    {
        //Sword class implements the Iweapon interface, code for the Sword useweapon method
        public string UseWeapon()
        {
            return "I shoot with my bow!";
        }
    }
}
