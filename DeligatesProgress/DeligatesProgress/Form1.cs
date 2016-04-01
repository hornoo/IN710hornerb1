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

namespace DeligatesProgress
{
    public partial class Form1 : Form
    {

        public delegate void FeedBackDelegate();

        FeedBackDelegate progresDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if(rbProgressBar.Checked)
            {
                progresDelegate = new FeedBackDelegate(updateProgressBar);
            }if(rbSpinBox.Checked)
            {
                progresDelegate = new FeedBackDelegate(updateSpinBox);
            }else
            {
                progresDelegate = new FeedBackDelegate(updatetrackbar);
            }

            for( int i =0 ; i < 10; i ++)
            {
                progresDelegate();
                Thread.Sleep(500);
                Application.DoEvents();
            }

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





    }
}
