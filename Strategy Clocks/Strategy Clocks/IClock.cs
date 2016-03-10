using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Clocks
{
    public interface IClock
    {
        void on();
        void off();
        void UpdateTimeDisplay();
        void ShowClock();
        void HideClock();
    }
}
