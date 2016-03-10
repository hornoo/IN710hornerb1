using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        List<PictureBox> DisplayPicBoxes;

        public PictureDisplay(List<PictureBox> displayPicBoxes)
        {
            DisplayPicBoxes = displayPicBoxes;
        }

       /* YOUR CODE HERE */
        public void displayCritterList(List<Critter> critterList)
        {
            int critterCount = critterList.Count;

            for (int i = 0; i < critterCount; i++)
            {
                DisplayPicBoxes[i].ImageLocation = critterList[i].ImageFileName;
            }
        }

        public void clearDisplay()
        {
            foreach(PictureBox currentBox in DisplayPicBoxes)
            {
                currentBox.Image = null;
            }
        }
    }
}
