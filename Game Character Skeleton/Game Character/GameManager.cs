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

        private Dictionary<String, Character> gameCharaterDic { get; set; }
        private

        public GameManager()
        {
            gameCharaterDic = new Dictionary<string, Character>();

            gameCharaterDic.Add("Stewie",new King(lisbox1))
        }
    }
}
