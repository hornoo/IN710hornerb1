using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        //reference to pass in listbox
        ListBox DisplayListBox;


        public TextDisplay(ListBox displayListBox)
        {
            //set reference to passed in list box from the form.
            DisplayListBox = displayListBox;
        }


        public void displayCritterList(List<Critter> critterList)
        {
            //foreach critter in the passed in list of critters, print their detials to the listbox
            foreach(Critter currentCritter in critterList)
            {
                DisplayListBox.Items.Add( currentCritter.Species + "," +currentCritter.Name);
            }
        }

        //Clear items from list box
        public void clearDisplay()
        {
            DisplayListBox.Items.Clear();
        }
    }
}
