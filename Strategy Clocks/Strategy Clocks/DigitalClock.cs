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
            //Set up clock with lable to print to, timer to control, interval of timer tick and initial time on clock.
            timeDisplay = digitalClock;
            timer = timerFromform;
            timer.Interval = timerIntervl;
            timeDisplay.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        //Stary the timer tick
        public void on()
        {
            timer.Start();
            
        }
        //stop the timer tick
        public void off()
        {
            timer.Stop();
        }

        //when called up date the label text with the curren time.
        public void UpdateTimeDisplay()
        {
            timeDisplay.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Toggile the visability of the clock
        public void ToggleClockVis()
        {
            timeDisplay.Visible = !timeDisplay.Visible;
        }

        
    }
}
