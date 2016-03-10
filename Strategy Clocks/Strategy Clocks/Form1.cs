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
            DigiClock = new DigitalClock(lbDigital, timer1);
            AnaClock = new AnalogueClock(analogClock1);
            clockWorker = new ClockManager();
            clockWorker.ClockMachine = DigiClock;
            clockWorker.StartClock();
        }

        private void rdAnalogue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDigital_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockWorker.updateDisplay();
        }









    }
}
