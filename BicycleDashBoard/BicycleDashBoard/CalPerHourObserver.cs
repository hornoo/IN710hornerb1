using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{//Child of BicycleObserver class, subject calls this classes updateMethod and passes in data.
    public class CalPerHourObserver : BicycleObserver
    {
        const int CAL_PER_HOUR_MULTIPLIER = 5;


        //Constructor
        public CalPerHourObserver(SubjectBicycle bikeSubject, Label displayLabel)
         : base(bikeSubject, displayLabel)
        {

        }


        //passed in data is processed and stored in the currentComputedValue and then the Display() method is called
        public override void Update(int data)
        {
            currentRPM = data;

            currentComputedValue = currentRPM * CAL_PER_HOUR_MULTIPLIER;

            Display();
        }
    }
}
