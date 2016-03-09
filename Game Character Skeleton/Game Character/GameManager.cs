using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class GameManager
    {
        //Dictionary to store players
        public Dictionary<String, Character> gameCharaterDic { get; set; }
       
        //Gamemanager constructor, seeds game initally with players
        public GameManager()
        {
            gameCharaterDic = new Dictionary<string, Character>();

            gameCharaterDic.Add("Stewie", new King("Stewie"));
            gameCharaterDic.Add("Meg", new Queen("Meg"));
            gameCharaterDic.Add("Lois", new Queen("Lois"));
            gameCharaterDic.Add("Brian", new Knight("Brian"));
            gameCharaterDic.Add("Chris", new Troll("Chris"));
        }

        //method to add players accepts a charater and reeturns a dictionary of update players,
        public Dictionary<String, Character>  AddCharater(Character characterToAdd)
        {
            //check is name already exists if it does return default dictionary
            if (gameCharaterDic.ContainsKey(characterToAdd.characterName))
            {
                return gameCharaterDic;
            }
            else
            {
                //else add the the new player and return the update dictionary
                gameCharaterDic.Add(characterToAdd.characterName, characterToAdd);
                return gameCharaterDic;
            }
        }

        //changes the players weapon
        public void changeWeapon(IWeapon newWeapon, String player)
        {
            //accepts a weapon object and sting wich is the key for the player, changes the weapon for that player in the dictionary
            gameCharaterDic[player].weapon = newWeapon;
        }


    }
}
