using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public class CalPerHourObserver : BicycleObserver
    {
        const int CAL_PER_HOUR_MUTIPLIER = 5;

        public CalPerHourObserver(SubjectBicycle bikeSubject, Label displayLabel)
         : base(bikeSubject, displayLabel)
        {

        }

        public override void Update(int data)
        {
            currentRPM = data;

            currentComputedValue = currentRPM * CAL_PER_HOUR_MUTIPLIER;

            Display();
        }
    }
}
