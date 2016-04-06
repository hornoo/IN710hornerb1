using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{
    class FireAlarmEventArgs : EventArgs
    {
        public String AlertString { get; set; }

        public FireAlarmEventArgs(String inputString)
        {
            AlertString = inputString;
        }
    }
}
