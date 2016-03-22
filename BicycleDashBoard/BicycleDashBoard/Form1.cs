using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public partial class Form1 : Form
    {
        SubjectBicycle bikeWorker;
        RPMObserver rpmDisplay;
        CalPerHourObserver calDisplay;
        KMHObserver kmhDisplay;

        public Form1()
        {
            InitializeComponent();
            bikeWorker = new SubjectBicycle();
            rpmDisplay = new RPMObserver(bikeWorker, lbRPM);
            calDisplay = new CalPerHourObserver(bikeWorker, lbCal);
            kmhDisplay = new KMHObserver(bikeWorker, lbkmsh);

        }

        private void btTrigger_Click(object sender, EventArgs e)
        {
            bikeWorker.InputTrigger(tbspeed.Text);
        }

 
    }
}
