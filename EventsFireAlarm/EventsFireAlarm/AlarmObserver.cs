using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{
    public abstract class AlarmObserver
    {
        protected AlarmSubject subject;

        protected String alertString;


        public AlarmObserver(AlarmSubject Subject)
        {
            subject = Subject;
            // Create alarm delegate event handler and assign method to run when  event is rased
            AlarmSubject.alarmDelegateEventHandler alertMethodDelegate = new AlarmSubject.alarmDelegateEventHandler(AlertMethod);

            //Subscribe to event.
            subject.fireEvent += alertMethodDelegate;

        }

        //Abstract method to run when event occours.
        public abstract void AlertMethod(object o, FireAlarmEventArgs e);
        
    }
}
