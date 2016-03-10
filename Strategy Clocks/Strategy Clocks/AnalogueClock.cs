using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalogClockControl;

namespace Strategy_Clocks
{
   public class AnalogueClock : IClock 
    {
       AnalogClock AnalogueClockDisplay;

       public AnalogueClock(AnalogClock analogueClock)
       {
           AnalogueClockDisplay = analogueClock;
       }

        public void on()
        {
            throw new NotImplementedException();
        }

        public void off()
        {
            throw new NotImplementedException();
        }

        public void UpdateTimeDisplay()
        {
            throw new NotImplementedException();
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
