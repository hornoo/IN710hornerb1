using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{

    enum FireCatEnum { Minor, Serious, Inferno };

    public class FireAlarmEventArgs : EventArgs
    {
        public FireCatEnum Alert { get; set; }

        public FireAlarmEventArgs(FireCatEnum AlertLevel)
        {
            Alert = AlertLevel;
        }
    }
}
