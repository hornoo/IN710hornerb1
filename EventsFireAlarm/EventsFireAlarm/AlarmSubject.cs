using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{
    
    public class AlarmSubject
    {
        public delegate void alarmDelegateEventHandler(object o, FireAlarmEventArgs e);

        public event alarmDelegateEventHandler fireEvent;

        public void OnFireEvent(FireCatEnum AlertLevel)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(AlertLevel);

            if(fireEvent != null)
            {
                fireEvent(this,fe);
            }

        }
    
    }
}
