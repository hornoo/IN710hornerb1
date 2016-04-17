using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlPubandClub
{
    class DisplayWorker
    {
        public DisplayWorker()
        {

        }

        public void PrintToListBox(ListBox inputListBox, List<String[]> inputlist)
        {
            inputListBox.Items.Clear();

            //inputlist.ForEach(currentStringArray => inputListBox.Items.Add(currentStringArray[0] + " " + currentStringArray[1] + " " + currentStringArray[0]));

            foreach(String[] currentArray in inputlist )
            {
                String outputString = "";
                foreach(String currentString in currentArray )
                {
                    outputString += currentString + " ";
                }
                inputListBox.Items.Add(outputString);
            }
        }

        public void PrintToDataGrid(DataGridView inputGrid, List<string[]> inputList)
        {
            inputGrid.Rows.Clear();

            DataGridViewRowCollection dgvRows = inputGrid.Rows;

            inputList.ForEach(currentStringArray => dgvRows.Add(currentStringArray));
        }
    }
}
