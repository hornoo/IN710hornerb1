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

       //pass in clock object from form to control
       public AnalogueClock(AnalogClock analogueClock)
       {
           AnalogueClockDisplay = analogueClock;
       }

       //Start the clock 
        public void on()
        {
            AnalogueClockDisplay.Start();
        }

       //Stop the clock
        public void off()
        {
            AnalogueClockDisplay.Stop();
        }

       //Not required for analoge  clock, but left over grom clock interface, not good practice but dont no how to pass in timer object yet
        public void UpdateTimeDisplay()
        {
            
        }
       //toggel visabilty of clock
        public void ToggleClockVis()
        {
            AnalogueClockDisplay.Visible = !AnalogueClockDisplay.Visible;
        }

    }
}
