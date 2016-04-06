using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsFireAlarm
{
    class AlarmMessageAlertObserver : AlarmObserver
    {

        public AlarmMessageAlertObserver(AlarmSubject subject) 
        : base(subject)
        {

        }


        public override void AlertMethod(object o, FireAlarmEventArgs e)
        {
            String alertMessage = null;

            switch(e.Alert)
            {
                case FireCatEnum.Minor :
                    alertMessage = "Fire is Minor, use extinguisher";
                    break;
                case FireCatEnum.Serious :
                    alertMessage = " Fire Serious, Call the Fire Brigade";
                    break;
                case FireCatEnum.Inferno :
                    alertMessage = "Fire is an Inferno, put on your disco shoes and crank up the Tramps";
                    break;
                default:
                    alertMessage = "false alarm";
                    break;
            }


            MessageBox.Show(alertMessage);

        }
    }
}
