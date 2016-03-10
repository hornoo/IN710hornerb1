using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        ListBox DisplayListBox;


        public TextDisplay(ListBox displayListBox)
        {
            DisplayListBox = displayListBox;
        }

        /* YOUR CODE HERE */
        public void displayCritterList(List<Critter> critterList)
        {
            foreach(Critter currentCritter in critterList)
            {
                DisplayListBox.Items.Add( currentCritter.Species + "," +currentCritter.Name);
            }
        }

        public void clearDisplay()
        {
            DisplayListBox.Items.Clear();
        }
    }
}
