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

            AlarmSubject.alarmDelegateEventHandler alertMethodDelegate = new AlarmSubject.alarmDelegateEventHandler(AlertMethod);

            subject.fireEvent += alertMethodDelegate;


        }

        public abstract void AlertMethod(object o, FireAlarmEventArgs e);
        
    }
}
