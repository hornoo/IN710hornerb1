﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Sword : IWeapon
    {//KSword class implements the Iweapon interface, code for the Sword useweapon method
        public string UseWeapon()
        {
            return "I slice with my sword!";
        }
    }
}
