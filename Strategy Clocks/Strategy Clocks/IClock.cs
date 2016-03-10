using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Clocks
{
    public interface IClock
    {//Clock inter face to set the required methods for each clock interface
        void on();
        void off();
        void UpdateTimeDisplay();
        void ToggleClockVis();
    }
}
