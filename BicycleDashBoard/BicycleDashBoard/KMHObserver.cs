using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public class KMHObserver : BicycleObserver
    {
        const int wheelCircumference = 205;
        const int minutesinHour = 60;
        const double cmInKM = 100000;

        public KMHObserver(SubjectBicycle bikeSubject, Label displayLabel)
        : base(bikeSubject, displayLabel)
        {

        }

        public override void Update(int data)
        {
            currentRPM = data;

            currentComputedValue = (double)(currentRPM * wheelCircumference * minutesinHour) / cmInKM ;

            Display();
        }
    }
}
