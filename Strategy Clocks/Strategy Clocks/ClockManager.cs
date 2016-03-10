using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Clocks
{
    public class ClockManager
    {
        public IClock ClockMachine {get; set;}

        public ClockManager()
        {

        }

        public void StartClock() 
        {
            ClockMachine.on();
        }

        public void StopClock()
        {
            ClockMachine.off();
        }

        public void ShowClock()
        {
            ClockMachine.ShowClock();
        }

        public void HideClock()
        {
            ClockMachine.HideClock();
        }

        public void updateDisplay()
        {
            ClockMachine.UpdateTimeDisplay();
        }


    }
}
