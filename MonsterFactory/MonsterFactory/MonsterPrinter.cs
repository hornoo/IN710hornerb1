using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFactory
{
    public class MonsterPrinter
    {
        public MonsterPrinter()
        {

        }


        //Print each part to picturbox
        public void printMonster(List<PictureBox> printBoxes, MonsterBuilder monster)
        {
            printBoxes[0].ImageLocation = monster.headpicture();
            printBoxes[1].ImageLocation = monster.bodyPictur();
            printBoxes[2].ImageLocation = monster.legPicture();
        }
    }
}
