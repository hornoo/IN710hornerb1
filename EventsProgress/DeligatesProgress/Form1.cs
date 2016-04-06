using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EventsProgress
{
    public partial class Form1 : Form
    {

        SlowWorker slowWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {

            slowWorker.SlowMetthod();
        }


        private void updateSpinBox()
        {
            UD1.Value++;
        }

        private void updateProgressBar()
        {
            PB1.PerformStep();
        }

        private void updatetrackbar()
        {
            TB1.Value++;
        }

        private void setProgressToZero()
        {
            UD1.Value = 0;
            PB1.Value = 0;
            TB1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            slowWorker = new SlowWorker();
        }





    }
}
