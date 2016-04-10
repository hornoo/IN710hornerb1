using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{
    
    public class AlarmSubject
    {
        //Declare delegate for custom event with data.
        public delegate void alarmDelegateEventHandler(object o, FireAlarmEventArgs e);

        //Set event 
        public event alarmDelegateEventHandler fireEvent;

        //Set methof to run this event and pass in the type of fire alarm via the data bucket
        public void OnFireEvent(FireCatEnum AlertLevel)
        {
            //instantiate firealarmeventargs object and pass in via the event.
            FireAlarmEventArgs fe = new FireAlarmEventArgs(AlertLevel);

            if(fireEvent != null)
            {
                fireEvent(this,fe);
            }

        }
    
    }
}
