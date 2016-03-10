using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Clocks
{

    public class DigitalClock : IClock
    {
        Label timeDisplay;
        Timer timer;
        int timerIntervl = 1000;

        public DigitalClock(Label digitalClock, Timer timerFromform)
        {
            timeDisplay = digitalClock;
            timer = timerFromform;
            timer.Interval = timerIntervl;
        }

        public void on()
        {
            timer.Start();
            
        }

        public void off()
        {
            throw new NotImplementedException();
        }

        public void UpdateTimeDisplay()
        {
            timeDisplay.Text = DateTime.Now.ToString();
        }

        public void ShowClock()
        {
            throw new NotImplementedException();
        }

        public void HideClock()
        {
            throw new NotImplementedException();
        }


        
    }
}
