﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class King : Character
    {
        public King(String characterName):base(characterName)
        {

        }
        public override string Declaim()
        {
            return "I am the most mighty King!";
        } 


    }
}
