using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum characterType
{
    king,Queen,Knight,Troll
}

namespace Game_Character
{
    //Class is abstract as this cannot be instantiated as it has an imcomplete method that is covered by a child class
    public abstract class Character
    {
        //Name Field
        public String characterName { get; set; }
       
        //Weapon object that change be changed with out modifing class
        public IWeapon weapon{get; set;}
      
        //Constructor which sets name when cinstantiated
        public Character(String characterName)
        {
            this.characterName = characterName;
        }

        //<ehtod to state charaters name
        public String StateName()
        {
            return "My name is " + characterName + "!";
        }

        //Abstareact method, impelement in child classes
        public abstract String Declaim();


        //Tostring over ride
        public override string ToString()
        {
            return StateName() + " " + Declaim() + " " + weapon.UseWeapon();
        }
    }
}
