using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMandLINQ
{
    public partial class Form1 : Form
    {
        DataBaseWorker dbWorker;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAvIntenseAllStrikes_Click(object sender, EventArgs e)
        {
            dbWorker.AverageIntensityOfAllStrikes();
        }

        private void btLargestThreeFires_Click(object sender, EventArgs e)
        {
            dbWorker.RecordsOfThreeLargestFires();
        }

        private void btPicInfo_Click(object sender, EventArgs e)
        {
            dbWorker.LatLongFilenameOfEachPicture();
        }

        private void btFirebyLightning_Click(object sender, EventArgs e)
        {
            dbWorker.FireByLightningSrike();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbWorker = new DataBaseWorker(listBox1);
        }
    }
}
