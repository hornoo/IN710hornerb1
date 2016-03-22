using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{//Child of BicycleObserver class, subject calls this classes updateMethod and passes in data.
    public class KMHObserver : BicycleObserver
    {
        //Values for computation of data.
        const int wheelCircumference = 205;
        const int minutesinHour = 60;
        const double cmInKM = 100000;

        //Constructor
        public KMHObserver(SubjectBicycle bikeSubject, Label displayLabel)
        : base(bikeSubject, displayLabel)
        {

        }
        //passed in data is processed and stored in the currentComputedValue and then the Display() method is called
        public override void Update(int data)
        {
            currentRPM = data;

            currentComputedValue = (double)(currentRPM * wheelCircumference * minutesinHour) / cmInKM ;

            Display();
        }
    }
}
