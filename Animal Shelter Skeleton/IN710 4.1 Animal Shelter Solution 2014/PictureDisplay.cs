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
        //reference to pass in list of pictureboxes
        List<PictureBox> DisplayPicBoxes;

        public PictureDisplay(List<PictureBox> displayPicBoxes)
        {   //set reference to passed in list of picture boxes from the form.
            DisplayPicBoxes = displayPicBoxes;
        }

       
        //Display pictures of criters on picture boxes from passed in list of critters
        public void displayCritterList(List<Critter> critterList)
        {
            //Set index could be 1 to 4 critters
            int critterCount = critterList.Count;

            //For each critter at index set picture picture box in picturbox array at the index.
            for (int i = 0; i < critterCount; i++)
            {
                DisplayPicBoxes[i].ImageLocation = critterList[i].ImageFileName;
            }
        }

        public void clearDisplay()
        {
            //set pictur box image to null for each picture.
            foreach(PictureBox currentBox in DisplayPicBoxes)
            {
                currentBox.Image = null;
            }
        }
    }
}
