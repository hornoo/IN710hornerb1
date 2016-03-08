﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Troll : Character
    {

        public Troll(String characterName, ListBox gameOutput)
            : base(characterName, gameOutput)
        {
            weapon = new Bow();
        }
        public override string Declaim()
        {
            return "Trolls don't have time to chat!";    
        }
    }
}
