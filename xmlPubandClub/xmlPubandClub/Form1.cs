using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlPubandClub
{
    public partial class Form1 : Form
    {
        XMLWorker xmlWorker;
        DisplayWorker displayWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate worker class and pass in path to xml file.
            xmlWorker = new XMLWorker("pubsAndClubs.xml");
            displayWorker = new DisplayWorker();
        }

        private void btUpcoming_Click(object sender, EventArgs e)
        {
            displayWorker.PrintToDataGrid(dataGridView1, xmlWorker.UpcommingGigs());
        }

        private void btHardRock_Click(object sender, EventArgs e)
        {
            displayWorker.PrintToDataGrid(dataGridView1, xmlWorker.HardRockGigs());
        }

        private void btThisMonth_Click(object sender, EventArgs e)
        {
            displayWorker.PrintToDataGrid(dataGridView1, xmlWorker.currentMonthGigs());
        }

        private void btSShakes_Click(object sender, EventArgs e)
        {
            displayWorker.PrintToListBox(listBox1, xmlWorker.AlabamaShakes());
        }

        private void btAddGig_Click(object sender, EventArgs e)
        {
            xmlWorker.addGig("TestBand", "IT", "OP", "08:30pm", 21, 4, 2016);
        }


    }
}
