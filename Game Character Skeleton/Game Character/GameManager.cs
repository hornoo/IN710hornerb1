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

        public Dictionary<String, Character> gameCharaterDic { get; set; }
       

        public GameManager()
        {
            gameCharaterDic = new Dictionary<string, Character>();

            gameCharaterDic.Add("Stewie", new King("Stewie"));
            gameCharaterDic.Add("Meg", new Queen("Meg"));
            gameCharaterDic.Add("Lois", new Queen("Lois"));
            gameCharaterDic.Add("Brian", new Knight("Brian"));
            gameCharaterDic.Add("Chris", new Troll("Chris"));
        }

        public Dictionary<String, Character>  AddCharater(Character characterToAdd)
        {
            if (gameCharaterDic.ContainsKey(characterToAdd.characterName))
            {
                return gameCharaterDic;
            }
            else
            {
                gameCharaterDic.Add(characterToAdd.characterName, characterToAdd);
                return gameCharaterDic;
            }
        }


    }
}
