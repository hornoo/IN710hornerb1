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

        public void PrintToDataGrid(DataGridView inputGrid, List<string[]> inputList)
        {
            DataGridViewRowCollection dgvRows = inputGrid.Rows;

            inputList.ForEach(currentStringArray => dgvRows.Add(currentStringArray));
        }
    }
}
