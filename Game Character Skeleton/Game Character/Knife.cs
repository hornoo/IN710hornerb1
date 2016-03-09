using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Knife : IWeapon
    {//Knife class implements the Iweapon interface, code for the knifes useweapon method
        public string UseWeapon()
        {
            return "I Stab with my knife!";
        }
    }
}
