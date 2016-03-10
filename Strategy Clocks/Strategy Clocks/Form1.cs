using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Clocks
{
    public partial class Form1 : Form
    {
        DigitalClock DigiClock;
        AnalogueClock AnaClock;
        ClockManager clockWorker;

        public Form1()
        {
            InitializeComponent();
            //Instantiate clock types
            DigiClock = new DigitalClock(lbDigital, timer1);
            AnaClock = new AnalogueClock(analogClock1);
            //Intsantiate  Clock worker to manage clocks
            clockWorker = new ClockManager();
            //Set up initial clock for clock worker
            clockWorker.ClockMachine = AnaClock;
            clockWorker.StopClock();
           
        }

        //Switch clocks displayed when radio button clicked
        private void rdAnalogue_CheckedChanged(object sender, EventArgs e)
        {
            //toggle visability of current clock
            clockWorker.ShowAndHideClock();
            //switch in anlogue clock
            clockWorker.ClockMachine = AnaClock;
            //show analogue clock
            clockWorker.ShowAndHideClock();

        }
        //Switch clocks displayed when radio button clicked

        private void rdDigital_CheckedChanged(object sender, EventArgs e)
        {
            //toggle visability of current clock
            clockWorker.ShowAndHideClock();
            //switch in Digital clock
            clockWorker.ClockMachine = DigiClock;
            //show Digital clock
            clockWorker.ShowAndHideClock();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // On each timer tick update screen(only required for digital clock)
            clockWorker.updateDisplay();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //Start current clockc
            clockWorker.StartClock();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            //Stop current clock;
            clockWorker.StopClock();
        }









    }
}
