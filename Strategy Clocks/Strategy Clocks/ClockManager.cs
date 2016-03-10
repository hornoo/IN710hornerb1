using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Clocks
{
    public class ClockManager
    {
        //set up reference to clock object on form
        public IClock ClockMachine {get; set;}

        public ClockManager()
        {

        }

        //start clock
        public void StartClock() 
        {
            ClockMachine.on();
        }

        //stop clock
        public void StopClock()
        {
            ClockMachine.off();
        }

        //togggle visablity of clock//
        public void ShowAndHideClock()
        {
            ClockMachine.ToggleClockVis();
        }

        //update clock time(digital clock only)
        public void updateDisplay()
        {
            ClockMachine.UpdateTimeDisplay();
        }


    }
}
