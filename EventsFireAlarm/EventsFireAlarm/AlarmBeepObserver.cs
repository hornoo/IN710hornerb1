using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsFireAlarm
{
    class AlarmBeepObserver : AlarmObserver
    {
        [DllImport("Kernel32.dll")]

        public static extern bool Beep(int freq, int duration);
        
        public AlarmBeepObserver(AlarmSubject subject)
        : base(subject)
        {

        }




        public override void AlertMethod(object o, FireAlarmEventArgs e)
        {
            switch (e.Alert)
            {
                case FireCatEnum.Minor:
                    Beep(800, 100);
                    break;
                case FireCatEnum.Serious:
                    Beep(1000, 100);
                    break;
                case FireCatEnum.Inferno:
                    Beep(1500, 100);
                    break;
                default:
                    Beep(800, 50);
                    break;
            }
        }
    }
}
